
namespace heranca
{
    public class Gerente : Funcionarios
    {
        public float Bonus;

        public float CalcularSalario()
        {
             return SalarioBase += Bonus;
           
        }
    }
}