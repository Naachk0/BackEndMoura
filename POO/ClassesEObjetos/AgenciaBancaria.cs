
namespace ClassesEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular = "";

        public float Saldo;

        public void Depositar(float ValorSaque)
        {
            if (ValorSaque <= 0)
            {
                Saldo += ValorSaque;
                Console.WriteLine($"Deposito ");
                
                return;

            }
            else
            {
                Console.WriteLine($"Saldo Insuficiente");
            }
        }

 public void Sacar (float ValorSaque)
        {
          Console.WriteLine($"saque feito com sucesso");
            if (ValorSaque > 0 && ValorSaque >= Saldo )
            {
                Console.WriteLine($"Saque feito com sucesso: {Saldo:F2}");
                return;
            }
            else
            {
                Console.WriteLine($"O valor do depositodeve ser positivo.");
                
            }
        }

    }
}