﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class Login : Form
    {
        private string userType;

        public Login(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            AutenticarUsuario();
        }

        private int ObterUsuarioId(string nomeUsuario)
        {
            int usuarioId = -1;

            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT ID FROM TB_USUARIO WHERE NM_USUARIO = @nomeUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    usuarioId = Convert.ToInt32(result);
                }
            }

            return usuarioId;
        }

        private void AutenticarUsuario()
        {
            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string usuario = txtUser.Text;
            string senha = txtSenha.Text;

            string queryAutenticar = "SELECT TP_USUARIO, NM_USUARIO FROM TB_USUARIO WHERE NM_USUARIO = @usuario AND SENHA = @senha";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commandAutenticar = new SqlCommand(queryAutenticar, connection);
                commandAutenticar.Parameters.AddWithValue("@usuario", usuario);
                commandAutenticar.Parameters.AddWithValue("@senha", senha);

                connection.Open();
                SqlDataReader reader = commandAutenticar.ExecuteReader();

                if (reader.Read())
                {
                    string tipoUsuario = reader["TP_USUARIO"].ToString();
                    string nomeUsuario = reader["NM_USUARIO"].ToString();

                    if (tipoUsuario == userType) // Verifica se o tipo de usuário corresponde ao esperado
                    {
                        if (tipoUsuario == "PROFESSOR")
                        {
                            Professor professorForm = new Professor(nomeUsuario);
                            professorForm.Show();
                        }
                        else if (tipoUsuario == "ALUNO")
                        {
                            int usuarioId = ObterUsuarioId(usuario);
                            Estudante estudanteForm = new Estudante(usuarioId);
                            estudanteForm.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Acesso negado para {userType.ToLower()}. Por favor, entre com as credenciais corretas.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Qualquer código necessário ao carregar o formulário de login
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mostrar o formulário Login
            Home loginForm = new Home();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mostrar o formulário Login
            Adicionar AdicionarForm = new Adicionar();
            AdicionarForm.Show();
        }
    }
}
