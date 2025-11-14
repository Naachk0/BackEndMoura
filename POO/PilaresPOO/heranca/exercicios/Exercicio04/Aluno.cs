

namespace heranca
{
    public class Aluno : Pessoa
    {
        public string Curso = "DEV";

        public void Aula()
        {
            Console.WriteLine($"Hoje o curso de {Curso} vai ser puxado!");
            
        }
    }
}