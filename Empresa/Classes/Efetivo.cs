namespace Empresa.Classes
{
    internal class Efetivo : Colaborador
    {
        public double SubsidioAlimentacao { get; set; }

        public Efetivo(string nome, double subsidioAlimentacao, double salarioBase) : base(nome, salarioBase, tipoContrato)
        {
            SubsidioAlimentacao = subsidioAlimentacao;
        }

        public override double CalcularVencimento()
        {
            return SalarioBase() + SubsidioAlimentacao - (SalarioBase() * 0.11);
        }
    }
}
