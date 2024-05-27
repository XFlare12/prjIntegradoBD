using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace prjIntegradoBD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            await AtualizarPrevisaoTempo();
        }

        private async Task AtualizarPrevisaoTempo()
        {
            string apiKey = "ccf2336593e5cca277f1a4f158a0d665";
            string cidade = "São Paulo";
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric&lang=pt_br";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject weatherData = JObject.Parse(responseBody);

                    string descricao = weatherData["weather"][0]["description"].ToString();
                    string temperatura = weatherData["main"]["temp"].ToString();

                    lblTempo.Text = $"Tempo em São Paulo: {descricao}, {temperatura}°C";
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Erro ao obter a previsão do tempo: " + ex.Message);
                }
            }
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

        private void lblTempo_Click(object sender, EventArgs e)
        {
            // Qualquer ação necessária ao clicar no lblTempo
        }
    }
}
