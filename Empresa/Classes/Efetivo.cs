namespace Empresa.Classes
{
    public class Efetivo : Colaborador
    {
        public double SubsidioAlimentacao { get; set; }

        public Efetivo(string nome, double subsidioAlimentacao, double salarioBase, string _tipoContrato) : base(nome, salarioBase, _tipoContrato)
        {
            SubsidioAlimentacao = subsidioAlimentacao;
        }

        public override double CalcularVencimento()
        {
            return SalarioBase() + SubsidioAlimentacao - (SalarioBase() * 0.11);
        }
    }
}
