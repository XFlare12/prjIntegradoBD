using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 
            string query = "SELECT TP_USUARIO FROM TB_USUARIO WHERE NM_USUARIO = @username AND SENHA = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", txtUser.Text);
                command.Parameters.AddWithValue("@password", txtSenha.Text);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string userType = result.ToString();

                        if (userType == "PROFESSOR")
                        {
                            Professor professorForm = new Professor();
                            professorForm.Show();
                        }
                        else if (userType == "ALUNO")
                        {
                            Estudante estudanteForm = new Estudante();
                            estudanteForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tipo de usuário não reconhecido.");
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
