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

        private List<Efetivo> efetivosRegister;

        private List<Freelancer> freelancersRgister;

        public Register(List<Efetivo> efetivos, List<Freelancer> freelancers)
        {
            InitializeComponent();

            panelFree.Visible = false;

            efetivosRegister = efetivos;
            freelancersRgister = freelancers;
        }

        private void typeContractBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
