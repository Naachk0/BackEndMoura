
namespace Calculadora
{
    public class CalculadoraMoura
    {
        public double Numero1;
        public double Numero2;
        public double Resultado;

        public double Somar() 
        {
            Resultado = Numero1 + Numero2;
            Console.WriteLine($"resultado da conta é {Resultado}");
            return Resultado;
            
         }
        public double Subtrair() 
        {
            Resultado = Numero1 - Numero2;
            Console.WriteLine($"resultado da conta é {Resultado}");
            return Resultado;

         }
        public double Dividir()
        {
            if (Numero2 == 0)
            {
                Console.WriteLine($"Não existe divisão por zero.");
                
         }

            Resultado = Numero1 / Numero2;
            Console.WriteLine($"resultado da conta é {Resultado}");
            return Resultado;

         }
        public double Multiplicar() 
        {
            Resultado = Numero1 * Numero2;
            Console.WriteLine($"resultado da conta é {Resultado}");
            return Resultado;

         }

    }
}