using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace prjIntegradoBD
{
    public partial class Estudante : Form
    {
        private int alunoID;

        public Estudante()
        {
            InitializeComponent();
        }

        public Estudante(int id)
        {
            InitializeComponent();
            alunoID = id;
        }

        private void Estudante_Load(object sender, EventArgs e)
        {
            LoadNotas();
        }

        private void LoadNotas()
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = @"
        SELECT DISCIPLINA, NOTA_B1, NOTA_B2, NOTA_B3, NOTA_B4, STATUS, NM_ALUNO 
        FROM TB_NOTAS 
        WHERE TB_ALUNOID = @alunoID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@alunoID", alunoID);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvNotas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar as notas: " + ex.Message);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarParaExcel();
        }

        private void ExportarParaExcel()
        {
            if (dgvNotas.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "Notas.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                DataTable dataTable = ((DataTable)dgvNotas.DataSource);
                                workbook.Worksheets.Add(dataTable, "Notas");
                                workbook.SaveAs(sfd.FileName);
                                MessageBox.Show("Dados exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao exportar os dados: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há dados para exportar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            Home loginForm = new Home();
            loginForm.Show();
        }

        private void Estudante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
