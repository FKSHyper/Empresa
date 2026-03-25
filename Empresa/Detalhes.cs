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
        private List<Efetivo> efetivosDetalhes;

        private List<Freelancer> freelancersDetalhes;
        public bool IsEfetivo { get; set; }
        public Detalhes(List<Efetivo> efetivos, List<Freelancer> freelancers)
        {
            InitializeComponent();

            panelFree.Visible = false;

            efetivosDetalhes = efetivos;
            freelancersDetalhes = freelancers;
        }

        private void btnPesquisarDet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
