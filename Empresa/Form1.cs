using Empresa.Classes;
using Microsoft.Win32;
using System.Collections.Generic;
using static Empresa.Register;

namespace Empresa
{
    public partial class Form1 : Form
    {
        public List<Efetivo> efetivos = new List<Efetivo>();

        public List<Freelancer> freelancers = new List<Freelancer>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnRegisto_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register registo = new Register(efetivos, freelancers);

            registo.IsEfetivo = true;

            if(registo.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                efetivos.AddRange(registo.Efetivos);
                freelancers.AddRange(registo.Freelancers);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalhes detalhes = new Detalhes(efetivos, freelancers);
            detalhes.Show();
        }

        private void btnEstat_Click(object sender, EventArgs e)
        {
            Estatisticas estat = new Estatisticas(efetivos, freelancers);
            btnEstat.Enabled = false;
            estat.Show();
            estat.FormClosed += (s, args) => btnEstat.Enabled = true;
        }
    }
}
