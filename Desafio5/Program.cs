// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia 
// e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas
// calcule e escreva o valor total da compra.

int maçãs;
int preco; 
Console.WriteLine($"Digite quantas maçãs você quer comprar.");
maçãs = int.Parse(Console.ReadLine());

if (maçãs >= 12 )
{
   preco = maçãs * 025;
Console.WriteLine($"o preco fica {preco} ");

}
else
{
   preco = maçãs * 030;
Console.WriteLine($"o preco fica {preco} ");
    
}


