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
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        private void Professor_Load(object sender, EventArgs e)
        {

        }
        private void Estudante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Isso garantirá que a aplicação inteira encerre quando o formulário Estudante for fechado
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mostrar o formulário Login
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
