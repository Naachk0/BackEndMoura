// pergunTar ao usuario quantos numeros ele quer digitar e separar os numeros pares e numeros impares

int qtdnumeros = 0;

Console.WriteLine("Ola usuario, quantos numeros quer digitar?");
qtdnumeros = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares = "Impares: ";

for (int i = 1; i < qtdnumeros; i++)
{
    Console.WriteLine($"Qual e o {i}ª numero?");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        pares += numeroDigitado.ToString();
    }
    else
    {
        impares += numeroDigitado.ToString();
    }

}

Console.Clear();
Console.WriteLine($"RESULTADO: ");
Console.WriteLine();
Console.WriteLine(pares);
