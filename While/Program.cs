
int contador = 1;
Console.WriteLine("Quantas vezes você quer rodar o While");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes)
{
    Console.WriteLine($"Contador é: {contador}");
    contador++;
}

//contador é: 1s