
namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string nome;

        public int Idade;

        public string altura;

      public void Falar()
        {
        Console.WriteLine($"CINERARIA!");
            
        }
    public void Andar()
    {
      Console.WriteLine($"estou ficando cansado...");

    }

    public void Envelhecer(int id = 0)
    {
      if (id > 0)
      {
        Idade += id;
      }
      else
      {
        // adiciona apenas 1 ano
      Idade++;
        
      }
    }

    }
}