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
            double valorHora;
            double salario;
            double alimentacao;

            if (typeContractBox.Text == "Freelancer")
            {
                int horas = Convert.ToInt32(hoursTxt.Text);

                if (!double.TryParse(valueHourTxt.Text, out valorHora))
                {
                    MessageBox.Show("Valor por hora inválido!");
                    return;
                }                
                
                Freelancers.Add(new Freelancer(nameTxt.Text, 0, horas, valorHora, typeContractBox.Text));
            }
            else
            {
                if (!double.TryParse(salaryTxt.Text, out salario))
                {
                    MessageBox.Show("Salário inválido!");
                    return;
                }

                if (!double.TryParse(AlimTxt.Text, out alimentacao))
                {
                    MessageBox.Show("Salário inválido!");
                    return;
                }

                Efetivos.Add(new Efetivo(nameTxt.Text, alimentacao, salario, typeContractBox.Text));
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
