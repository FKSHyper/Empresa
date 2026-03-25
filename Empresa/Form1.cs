using static Empresa.Register;

namespace Empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register registro = new Register();

            registro.Show();
        }
    }
}
