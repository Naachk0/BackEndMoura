

namespace Construtores
{
    public class Aluno
    {
        public string Nome;

        public float Nota;

 public Aluno( )
        {
           Console.WriteLine($"lista de alunos: ");
           
       
        }

public Aluno(string nome, float nota)
        {
            Nota = nota;
            Nome = nome;
        }
        public void ExibirDados()
        {

            Console.WriteLine($"O aluno: {Nome}, passou com a nota: {Nota}");

        }
    }
}