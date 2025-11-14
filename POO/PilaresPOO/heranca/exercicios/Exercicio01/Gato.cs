

namespace heranca
{
    public class Gato : AnimaisEsons
    {
        public string nome;
        public string cor;

        public void FazerSom()
        {
            Console.WriteLine($"Gato faz: MEOW MEOW MEOW!");

        }
    }
}