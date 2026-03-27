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
    public partial class Detalhes : Form
    {
        public int ID { get; set; } 

        private List<Efetivo> efetivosDetalhes;

        private List<Freelancer> freelancersDetalhes;
        public bool IsEfetivo { get; set; }
        public Detalhes(List<Efetivo> efetivos, List<Freelancer> freelancers)
        {
            InitializeComponent();

            panelFree.Visible = false;
            panelEfe.Visible = false;

            efetivosDetalhes = efetivos;
            freelancersDetalhes = freelancers;
        }

        private void btnPesquisarDet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_ID.Text, out int ID))
                return;
            Colaborador? colaborador = efetivosDetalhes.FirstOrDefault(e => e.Id == ID) as Colaborador
                ?? freelancersDetalhes.FirstOrDefault(f => f.Id == ID) as Colaborador;

            if (colaborador == null)
            {
                MessageBox.Show("Colaborador não existe.");
                return;
            }

            nameTxtDet.Text = colaborador.Nome();

            if (colaborador is Efetivo efetivo)
            {
                panelEfe.Visible = true;
                typeContractBoxDet.Text = "Efetivo";
                txt_SubAlimentação.Text = efetivo.SubsidioAlimentacao.ToString();
                salaryTxtDet.Text = efetivo.SalarioBase().ToString();
            }
            else if (colaborador is Freelancer freelancer)
            {
                panelFree.Visible = true;
                typeContractBoxDet.Text = "Freelancer";
                hoursTxtDet.Text = freelancer.HorasExtra.ToString();
                valueHourTxtDet.Text = freelancer.ValorHora.ToString();
            }
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txt_ID.Text, out int ID);
        }
    }
}
