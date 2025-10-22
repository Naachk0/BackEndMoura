// pergunte ao usuario quantas let+ras tem em seu nome
// pedir leyta a letra
// exibir no final o nome completo


int qtdLetras = 0;
string nome = "";

Console.WriteLine("Ola usuario, quantas letras tem o seu nome?");
qtdLetras = int.Parse(Console.ReadLine());

for (int i = 1; i < qtdLetras; i++)
{
    Console.WriteLine($"Qual e a {i}ª letra?");
    nome = nome + Console.ReadLine();
}

Console.WriteLine($"Seu nome e: {nome}");


// pergunTar ao usuario quantos numeros ele quer digitar e separar os numeros pares e numeros impares