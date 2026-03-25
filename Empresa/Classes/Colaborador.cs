namespace Empresa.Classes
{
    public abstract class Colaborador
    {
        private string _nome;

        public int Id { get; set; }

        private double _salarioBase;

        public string tipoContrato;

        public abstract double CalcularVencimento();

        Random random = new Random();

        public Colaborador(string nome, double salarioBase, string _tipoContrato)
        {
            _nome = nome;
            _salarioBase = salarioBase;
            Id = random.Next(1, 999);
            tipoContrato = _tipoContrato;
        }

        public double SalarioBase()
        {
            if (_salarioBase < 0)
            {
                _salarioBase = 0;
            }

            return _salarioBase;
        }

        public string Nome()
        {
            if (_nome == null)
            {
                MessageBox.Show("Nome não pode estar vazio !");
            }

            return _nome;
        }
    }
}
