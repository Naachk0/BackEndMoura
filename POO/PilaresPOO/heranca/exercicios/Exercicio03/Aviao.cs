

using heranca;

namespace PilaresPOO
{
    public class Aviao : Veiculo
    {
        public string Destino;

        public void Voar()
        {
  
            Console.WriteLine($"Aviao esta voando para {Destino}!!");
            

        } 
    }
}