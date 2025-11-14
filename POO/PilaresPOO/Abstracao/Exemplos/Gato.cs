

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Meow meow..");
            
        }
        public override void Mover()
        {
            Console.WriteLine($"tec..tec..tec..");
            
        }
    }
}