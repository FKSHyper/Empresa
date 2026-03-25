using Empresa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Register : Form
    {
        public bool IsEfetivo { get; set; }

        public List<Efetivo> Efetivos { get; set; }

        public List<Freelancer> Freelancers { get; set; }



        public Register(List<Efetivo> efetivos, List<Freelancer> freelancers)
        {
            InitializeComponent();

            Efetivos = new List<Efetivo>();
            Freelancers = new List<Freelancer>();

            panelFree.Visible = false;
            panelEfe.Visible = false;
        }

        private void typeContractBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeContractBox.Text == "Freelancer")
            {
                panelFree.Visible = true;
                panelEfe.Visible = false;
            }
            else
            {
                panelFree.Visible = false;
                panelEfe.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double valorHora = double.Parse(valueHourTxt.Text);
            double salario = double.Parse(salaryTxt.Text);
            int horas = Convert.ToInt32(hoursTxt.Text);

            if (typeContractBox.Text == "Efetivo")
            {
                Efetivos.Add(new Efetivo(nameTxt.Text, double.Parse(AlimTxt.Text), salario, typeContractBox.Text));
            }
            else
            {
                Freelancers.Add(new Freelancer(nameTxt.Text, salario, horas, valorHora, typeContractBox.Text));
            }
        }
    }
}
