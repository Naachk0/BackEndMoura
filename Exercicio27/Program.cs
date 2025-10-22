int qtdnumeros = 0;
int contador = 1;

Console.WriteLine("Quantos numeros voce quer digitar?");
qtdnumeros = int.Parse(Console.ReadLine());


while (contador <= qtdnumeros)
{
    Console.WriteLine($"Digite um numero");
    int numero1 = int.Parse(Console.ReadLine());

     if (numero1 % 2 == 0)
    {
        Console.WriteLine("numero digitado é par: {numero1} ");
    }
    contador++;
}