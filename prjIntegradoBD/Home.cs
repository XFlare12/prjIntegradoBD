using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Qualquer inicialização que você precisar
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            // Abre o formulário de Login para Aluno
            Login loginForm = new Login("ALUNO");
            loginForm.Show();
            this.Hide();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            // Abre o formulário de Login para Professor
            Login loginForm = new Login("PROFESSOR");
            loginForm.Show();
            this.Hide();
        }
    }
}
