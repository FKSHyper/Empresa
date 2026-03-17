namespace Empresa.Classes
{
    abstract class Colaborador
    {
        private string _nome;

        public int Id { get; set; }

        private double _salarioBase;

        public abstract double CalcularVencimento();

        Random random = new Random();

        public Colaborador(string nome, double salarioBase)
        {
            _nome = nome;
            _salarioBase = salarioBase;
            Id = random.Next(1, 999);
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
