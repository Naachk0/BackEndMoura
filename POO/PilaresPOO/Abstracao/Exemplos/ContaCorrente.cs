

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo = 0;
        private double Taxa = 5;

public ContaCorrente(double SaldoInicial)
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