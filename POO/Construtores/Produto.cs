
namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public float Preco;
        public int Estoque;

        public Produto()
        {
            Console.WriteLine($"Lista de {Nome}");
            
        }

        public Produto(string n, float preco, int est)
        {
            Nome = n;
            Preco = preco;
            Estoque = est;
        }

public void ExibirDados()
        {

            Console.WriteLine($"você proccura uma: {Nome}, ela está por R${Preco} e há {Estoque} no estoque");

        }
    }
}