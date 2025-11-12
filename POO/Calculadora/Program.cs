using Calculadora;

CalculadoraMoura Calc = new CalculadoraMoura();

// Calc.Numero1 = 50;
// Calc.Numero2 = 20;



// Console.WriteLine($"Soma");
// Calc.Somar();
// Console.WriteLine($"");



// Console.WriteLine($"Subtrair");
// Calc.Subtrair();
// Console.WriteLine($"");



// Console.WriteLine($"Dividir");
// Calc.Dividir();
// Console.WriteLine($"");



// Console.WriteLine($"Multiplicação");
// Calc.Multiplicar();

int opcao;

        double Numero1;
        double Numero2;
        double Resultado;

do
{

Console.WriteLine($"============================ Calculadora inteligente  C# ==============================");
Console.WriteLine($"");
Console.WriteLine($"");
Console.WriteLine($"");
Console.WriteLine($" ---------------------  1 - somar");
Console.WriteLine($"----------------------  2 - subtrair");
Console.WriteLine($"----------------------  3 - dividir");
Console.WriteLine($"----------------------  4 - multiplicar");
Console.WriteLine($"----------------------  0 - Sair ");

Console.WriteLine($"");
Console.WriteLine($"Ola, digite a opcão desejada: ");
 opcao = int.Parse(Console.ReadLine());
Console.WriteLine($"");




    switch (opcao)
    {
        case 0:
            Saindo();
            Console.ReadLine();
            break;
        case 1:
            Somar();
            Console.ReadLine();
            break;
        case 2:
            Subtrair();
            Console.ReadLine();
            break;
        case 3:
            Dividir();
            Console.ReadLine();
            break;
        case 4:
            Multiplicar();
            Console.ReadLine();
            break;

        default:
            break;

    }

    Console.WriteLine($"Digite <Enter> para sair.");
    
} while (opcao != 0);
        


        double Somar()
{
    Console.WriteLine($"Digite o primeiro numero:");
    Numero1 = int.Parse(Console.ReadLine());
         
    Console.WriteLine($"Digite o primeiro numero:");
         Numero2 = int.Parse(Console.ReadLine());
        

         Resultado = Numero1 + Numero2;
        Console.WriteLine($"resultado da conta é {Resultado}");
        return Resultado;
        }
    

         double Subtrair()
{
            Console.WriteLine($"Digite o primeiro numero:");
    Numero1 = int.Parse(Console.ReadLine());
         
    Console.WriteLine($"Digite o primeiro numero:");
         Numero2 = int.Parse(Console.ReadLine());
        

         Resultado = Numero1 - Numero2;
        Console.WriteLine($"resultado da conta é {Resultado}");
         return Resultado;
        }
         

         double Dividir()
{
Console.WriteLine($"Digite o primeiro numero:");
    Numero1 = int.Parse(Console.ReadLine());
         
    Console.WriteLine($"Digite o primeiro numero:");
         Numero2 = int.Parse(Console.ReadLine());
        

    if (Numero2 == 0)
    {
        Console.WriteLine($"Não existe divisão por zero.");

    }

    Resultado = Numero1 / Numero2;
    Console.WriteLine($"resultado da conta é {Resultado}");
    return Resultado;

} 
         
         double Multiplicar()
{
    Console.WriteLine($"Digite o primeiro numero:");
    Numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o primeiro numero:");
    Numero2 = int.Parse(Console.ReadLine());


    Resultado = Numero1 * Numero2;
    Console.WriteLine($"resultado da conta é {Resultado}");
    return Resultado;

}
         void Saindo()
{
    Console.WriteLine($"Saindo....");
}