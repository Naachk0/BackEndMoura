float nota1, nota2, nota3, nota4, media;


Console.WriteLine("primeira nota: ");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("segunda nota: ");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("terceira nota: ");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("quarta nota: ");
nota4 = float.Parse(Console.ReadLine());

Console.Clear();

media = nota1 + nota2 + nota3 + nota4 / 4;

Console.WriteLine($"media: {media}");

if (media >= 7)
{
    Console.WriteLine("aprovado!!!");
}

else if (media <= 7)
{
    Console.WriteLine("recuperacao");
}

else
{
     Console.WriteLine("reprovado.");
};

