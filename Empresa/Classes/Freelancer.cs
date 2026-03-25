namespace Empresa.Classes
{
    internal class Freelancer : Colaborador
    {
        public int HorasExtra { get; set; }

        public double ValorHora { get; set; }

        public Freelancer(string _nome, double _salarioBase, int horasExtra, double ValorHora) : base(_nome, _salarioBase, _tipoContrato)
        {
            HorasExtra = horasExtra;
        }

        public override double CalcularVencimento()
        {
            return SalarioBase() + (HorasExtra * ValorHora);
        }
    }
}
