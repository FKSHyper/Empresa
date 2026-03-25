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
    public partial class Register : Form
    {
        public bool IsEfetivo { get; set; }

        public List<Efetivo> Efetivos { get; set; }

        public List<Freelancer> Freelancers { get; set; }

        public Register()
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
            if (typeContractBox.Text == "Efetivo")
            {
                Efetivos = new Efetivo(nameTxt.Text, AlimTxt.Text, salaryTxt.Text, typeContractBox.Text);
            }
            else
            {
                Freelancers = new Freelancer(nameTxt.Text, salaryTxt.Text, hoursTxt.Text, valueHourTxt.Text, typeContractBox.Text);
            }
        }
    }
}
