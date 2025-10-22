//.Faça um programa que solicite ao usuário um número de repetições “x”. Para cada
//repetição solicite dois números e imprima qual é o maior deles.

int qtdVezes = 0;
int numero1, numero2;
int contador = 1;

Console.WriteLine("Quantas vezes voce quer digitar?");
qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes) {

    Console.WriteLine("digite o primeiro numero");
    numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("digite o segundo numero");
    numero2 = int.Parse(Console.ReadLine());

    if (numero1 > numero2)
    {
        Console.WriteLine($"numero {numero1} digitado é maior ");
    }
    else if (numero1 == numero2)
    {
        Console.WriteLine($"numero {numero2} e {numero1} sao iguais");
    }
    else
    {
        Console.WriteLine($"numero {numero2} digitado é maior ");
    }
    contador++;
}