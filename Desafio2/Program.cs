
//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) 
// e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

int goltime1, goltime2;

Console.WriteLine("quantos gols o primeiro time fez?");
goltime1 = int.Parse(Console.ReadLine());

Console.WriteLine("quantos gols o segundo time fez?");
goltime2 = int.Parse(Console.ReadLine());

if (goltime1 > goltime2)
{
    
Console.WriteLine("o primeiro time ganhou!!");
}
else if ( goltime1 == goltime2)
{
    
Console.WriteLine("ambos os times empataram!!");
}
else
{
    
Console.WriteLine("o segundo time ganhou!!");
}
