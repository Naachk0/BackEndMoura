
namespace ClassesEObjetos
{
    public class ProdutoComDesconto
    {
        public string Nome;

        public double Preco;

public void AplicarDesconto(double Desconto = 0)
        {
            
            if (Desconto > 0 && Desconto <= 50)
            {
                Preco -= Preco / 100 * Desconto;
                Console.WriteLine($"O desconto foi de {Desconto}%");
            
            
            }
            else
            {
               Console.WriteLine($"Valor do desconto invalido");
                
            }

        }

    }
} 