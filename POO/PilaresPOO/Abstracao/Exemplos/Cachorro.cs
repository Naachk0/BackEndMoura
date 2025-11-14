
namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
           Console.WriteLine($"WOOF WOOF WOOF");
           
        }

        public override void Mover()
        {
            Console.WriteLine($"tec..tec..tec..");
            
        }
    }
}