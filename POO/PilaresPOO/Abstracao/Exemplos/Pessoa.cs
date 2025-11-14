
namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string Nome = "Lewis Hamilton";
        public int Idade = 40;


public  void Dormir()
        {
            Console.WriteLine($"rooounc...mimimimim...rooouc..mimiimi");
            
        }
        public override void FazerSom()
        {
            Console.WriteLine($"Vai de Shell-V Power");
            
        }

        public override void Mover()
        {
            Console.WriteLine($" pisa pisa pisa");
            
        }
    }
}