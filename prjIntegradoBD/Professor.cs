using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class Professor : Form
    {
        private string nomeUsuario;

        public Professor(string nomeUsuario)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
            lblDesc.Text = $"Olá Professor, {nomeUsuario}";

        }

        private void Professor_Load(object sender, EventArgs e)
        {
            CarregarDisciplina();
        }

        private void CarregarDisciplina()
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string queryDisciplina = "SELECT DISCIPLINA FROM TB_PROFESSORES WHERE NM_USUARIO = @nomeUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryDisciplina, connection);
                command.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);

                connection.Open();
                string disciplina = command.ExecuteScalar() as string;

                if (!string.IsNullOrEmpty(disciplina))
                {
                    txtDisciplina.Text = disciplina;
                }
                else
                {
                    MessageBox.Show("Disciplina não encontrada para o professor.");
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SalvarNotas();
        }

        private void SalvarNotas()
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string disciplina = txtDisciplina.Text;
            decimal notaB1 = decimal.Parse(txtNotaB1.Text);
            decimal notaB2 = decimal.Parse(txtNotaB2.Text);
            decimal notaB3 = decimal.Parse(txtNotaB3.Text);
            decimal notaB4 = decimal.Parse(txtNotaB4.Text);
            string anoLetivo = txtAnoLetivo.Text;
            int alunoId = int.Parse(txtAlunoID.Text);

            string queryVerificar = "SELECT COUNT(*) FROM TB_NOTAS WHERE TB_ALUNOID = @alunoId AND DISCIPLINA = @disciplina";
            string queryInserir = @"
                INSERT INTO TB_NOTAS (TB_ALUNOID, TB_AULAID, DISCIPLINA, NOTA_B1, NOTA_B2, NOTA_B3, NOTA_B4, ANO_LETIVO) 
                VALUES (@alunoId, @aulaId, @disciplina, @notaB1, @notaB2, @notaB3, @notaB4, @anoLetivo)";
            string queryAtualizar = @"
                UPDATE TB_NOTAS 
                SET NOTA_B1 = @notaB1, NOTA_B2 = @notaB2, NOTA_B3 = @notaB3, NOTA_B4 = @notaB4, ANO_LETIVO = @anoLetivo 
                WHERE TB_ALUNOID = @alunoId AND DISCIPLINA = @disciplina";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commandVerificar = new SqlCommand(queryVerificar, connection);
                commandVerificar.Parameters.AddWithValue("@alunoId", alunoId);
                commandVerificar.Parameters.AddWithValue("@disciplina", disciplina);

                connection.Open();
                int count = (int)commandVerificar.ExecuteScalar();

                SqlCommand command;

                if (count > 0)
                {
                    // Atualizar registro existente
                    command = new SqlCommand(queryAtualizar, connection);
                }
                else
                {
                    // Inserir novo registro
                    command = new SqlCommand(queryInserir, connection);
                }

                command.Parameters.AddWithValue("@alunoId", alunoId);
                command.Parameters.AddWithValue("@aulaId", 1); // Substitua pelo ID da aula apropriado
                command.Parameters.AddWithValue("@disciplina", disciplina);
                command.Parameters.AddWithValue("@notaB1", notaB1);
                command.Parameters.AddWithValue("@notaB2", notaB2);
                command.Parameters.AddWithValue("@notaB3", notaB3);
                command.Parameters.AddWithValue("@notaB4", notaB4);
                command.Parameters.AddWithValue("@anoLetivo", anoLetivo);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Notas salvas com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar as notas: " + ex.Message);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mostrar o formulário Login
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
