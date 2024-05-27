using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string senhaConfirm = txtSenhaConfirm.Text;

            // Verificar se apenas uma opção está selecionada
            if (checkOpcoes.CheckedItems.Count != 1)
            {
                MessageBox.Show("Por favor, selecione um tipo de usuário.");
                return;
            }

            string tipoUsuario = checkOpcoes.CheckedItems[0].ToString(); // Obter o tipo de usuário selecionado

            if (senha != senhaConfirm)
            {
                MessageBox.Show("As senhas não coincidem");
                return;
            }

            string connectionString = "Server=tcp:prj-uninove.database.windows.net,1433;Initial Catalog=projeto_uninove;Persist Security Info=False;User ID=OM3nezes;Password=RogerioFabi0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string queryInserir = "INSERT INTO TB_USUARIO (NM_USUARIO, SENHA, TP_USUARIO) VALUES (@usuario, @senha, @tipoUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Inserir novo usuário
                SqlCommand commandInserir = new SqlCommand(queryInserir, connection);
                commandInserir.Parameters.AddWithValue("@usuario", usuario);
                commandInserir.Parameters.AddWithValue("@senha", senha);
                commandInserir.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);

                try
                {
                    commandInserir.ExecuteNonQuery();
                    MessageBox.Show("Usuário criado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar usuário: " + ex.Message);
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
    }
}
