
namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
         public double Saldo = 0;
        private double Taxa = 3;

        public ContaPoupanca(double SaldoInicial)
        {
             Saldo = SaldoInicial;
        }

        public override void Depositar(double Valor)
        {
            if (Valor <= 0)
           {
            Console.WriteLine($"O valor deve ser positivo");
            return;
           }
           
           Saldo += Valor;
            }

        public override void Sacar(double Valor)
        {
            
double TotalTaxa = (Valor / 100 * Taxa);

            if (Valor <= 0 || Saldo >= TotalTaxa)
            {
            Console.WriteLine($"O valor deve ser positivo ou ter dinheiro na conta.");
            return;
            }
              Saldo -= TotalTaxa;
        }
    }
}