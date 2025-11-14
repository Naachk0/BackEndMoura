// Crie uma classe Funcionario com as propriedades Nome e SalarioBase.
// Crie uma classe Gerente que herde de Funcionario e possua um bônus adicional.
// Implemente um método CalcularSalario() que retorne o salário total considerando o bônus do gerente.
// Crie objetos das duas classes e exiba os salários no console

namespace heranca
{
    public class Funcionarios 
    {
        public string Nome;

        public float SalarioBase;

        public float CalcularSalario()
        {
            return SalarioBase;
        }
    }
}