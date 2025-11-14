

namespace heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina = "POO";

        public void Aula()
        {
            Console.WriteLine($"OS alunos teram aula de {Disciplina}");
            
        }
    }
}