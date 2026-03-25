using static Empresa.Register;

namespace Empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnRegisto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo registo = new Registo();
            registo.Show();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalhes detalhes = new Detalhes();
            detalhes.Show();
        }

        private void btnEstat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estatisticas estat = new Estatisticas();
            estat.Show();
        }
    }
}
