using Empresa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Estatisticas : Form
    {
        private List<Efetivo> efetivosEstat;

        private List<Freelancer> freelancersEstat;

        public Estatisticas(List<Efetivo> efetivos, List<Freelancer> freelancers)
        {
            InitializeComponent();
            efetivosEstat = efetivos;
            freelancersEstat = freelancers;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            double somaSalarios = efetivosEstat.Sum(e => e.SalarioBase()) + freelancersEstat.Sum(e => e.SalarioBase());
            double Ncolab = efetivosEstat.Count + freelancersEstat.Count;
            double impostos = somaSalarios * 0.11;
            double EGA = (somaSalarios - impostos) * 12;

            List<Colaborador> colaboradors = new List<Colaborador>();
            colaboradors.AddRange(efetivosEstat);
                colaboradors.AddRange(freelancersEstat);

            colaboradors.Max(e => e.SalarioBase());


            TxtNcolab.Text = (Ncolab).ToString();
            TxtValorGasto.Text = (somaSalarios).ToString();
            TxtMsB.Text = (somaSalarios / Ncolab).ToString();
            TxtImpostos.Text = (impostos).ToString();
            TxtEGA.Text = (EGA).ToString();
        }
    }
}
