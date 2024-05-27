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
            // Calcular a média das notas
            decimal notaB1 = decimal.Parse(txtNotaB1.Text);
            decimal notaB2 = decimal.Parse(txtNotaB2.Text);
            decimal notaB3 = decimal.Parse(txtNotaB3.Text);
            decimal notaB4 = decimal.Parse(txtNotaB4.Text);

            decimal media = (notaB1 + notaB2 + notaB3 + notaB4) / 4;

            // Determinar o status com base na média
            string status = media >= 6 ? "APROVADO" : "REPROVADO";

            // Chamar o método para salvar as notas e o status
            SalvarNotas(status);
        }

        private void SalvarNotas(string status)
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string disciplina = txtDisciplina.Text;
            decimal notaB1 = decimal.Parse(txtNotaB1.Text);
            decimal notaB2 = decimal.Parse(txtNotaB2.Text);
            decimal notaB3 = decimal.Parse(txtNotaB3.Text);
            decimal notaB4 = decimal.Parse(txtNotaB4.Text);

            int alunoId = int.Parse(txtAlunoID.Text);

            string queryVerificar = "SELECT COUNT(*) FROM TB_NOTAS WHERE TB_ALUNOID = @alunoId AND DISCIPLINA = @disciplina";
            string queryInserir = @"
                INSERT INTO TB_NOTAS (TB_ALUNOID, TB_AULAID, DISCIPLINA, NOTA_B1, NOTA_B2, NOTA_B3, NOTA_B4, STATUS) 
                VALUES (@alunoId, @aulaId, @disciplina, @notaB1, @notaB2, @notaB3, @notaB4, @status)";
            string queryAtualizar = @"
                UPDATE TB_NOTAS 
                SET NOTA_B1 = @notaB1, NOTA_B2 = @notaB2, NOTA_B3 = @notaB3, NOTA_B4 = @notaB4, STATUS = @status
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
                command.Parameters.AddWithValue("@status", status);  // Adicionando o parâmetro de status

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

            // Mostrar o formulário Home
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAluno();
        }

        private void BuscarAluno()
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            int alunoId = int.Parse(txtAlunoID.Text);

            string queryAluno = "SELECT NM_USUARIO, TP_USUARIO FROM TB_USUARIO WHERE ID = @alunoId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryAluno, connection);
                command.Parameters.AddWithValue("@alunoId", alunoId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nomeAluno = reader["NM_USUARIO"].ToString();
                        string tipoUsuario = reader["TP_USUARIO"].ToString();

                        if (tipoUsuario == "ALUNO")
                        {
                            lblAluno.Text = $"Lançando notas para o aluno: {nomeAluno}";
                        }
                        else
                        {
                            MessageBox.Show($"O usuário de ID {alunoId} não é um aluno.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aluno não encontrado.");
                    }
                }
            }
        }

        private void lblAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirAluno();
        }

        private void ExcluirAluno()
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            int alunoId = int.Parse(txtAlunoID.Text);

            string queryVerificar = "SELECT TP_USUARIO FROM TB_USUARIO WHERE ID = @alunoId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commandVerificar = new SqlCommand(queryVerificar, connection);
                commandVerificar.Parameters.AddWithValue("@alunoId", alunoId);

                connection.Open();
                string tipoUsuario = commandVerificar.ExecuteScalar() as string;

                if (tipoUsuario == "ALUNO")
                {
                    string queryExcluir = "DELETE FROM TB_USUARIO WHERE ID = @alunoId";

                    SqlCommand commandExcluir = new SqlCommand(queryExcluir, connection);
                    commandExcluir.Parameters.AddWithValue("@alunoId", alunoId);

                    try
                    {
                        commandExcluir.ExecuteNonQuery();
                        MessageBox.Show("Aluno excluído com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir aluno: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao tentar excluir professor.");
                }
            }
        }
    }
}
