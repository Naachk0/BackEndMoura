// Baseado no programa do exercício número 9, crie um programa que contenha o menu para os
//  exercícios de 1 a 6, onde cada programa/menu deve executar uma função.

int exercicio;

do
{
    Console.Clear();

    Console.WriteLine($"Escolha o exercicio que voce quer executar");
    Console.WriteLine($"Desafio1");
    Console.WriteLine($"Desafio2");
    Console.WriteLine($"Desafio3");
    Console.WriteLine($"Desafio4");
    Console.WriteLine($"Desafio5");
    Console.WriteLine($"Desafio6");
    Console.WriteLine($"Desafio7 - MenucomSwitch");
    
    

    Console.WriteLine($"Exercicio: ");
    exercicio = int.Parse(Console.ReadLine());

    switch (exercicio)
    {
        case 1:
            Desafio1();
            break;
    
        case 2:
            Desafio2();
            break;
        

        case 3:
            Desafio3();
            break;
      
        case 4:
            Desafio4();
            break;
      

        case 5:
            Desafio5();
            break;
    

        case 6:
            Desafio6();
            break;
      

        case 7:
            Desafio7();
            break;

    }
    
    
} while (exercicio != 0);

void Desafio1 ()
{

    double salario;
    int gastos;

    Console.WriteLine("qual seu salario recebido?");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("de quantos sao seus gastos?");
    gastos = int.Parse(Console.ReadLine());

    if (gastos < salario)
    {
        Console.WriteLine("Gastos dentro do orçamento");

    }
    else
    {
        Console.WriteLine("Orçamento estourado");


    }
}

void Desafio2()
{

    int goltime1, goltime2;

    Console.WriteLine("quantos gols o primeiro time fez?");
    goltime1 = int.Parse(Console.ReadLine());

    Console.WriteLine("quantos gols o segundo time fez?");
    goltime2 = int.Parse(Console.ReadLine());

    if (goltime1 > goltime2)
    {

        Console.WriteLine("o primeiro time ganhou!!");
    }
    else if (goltime1 == goltime2)
    {

        Console.WriteLine("ambos os times empataram!!");
    }
    else
    {

        Console.WriteLine("o segundo time ganhou!!");
    }

}

void Desafio3 ()
{

    int lado1, lado2, lado3;

    Console.WriteLine("Digite as medidas do seu triangulo.");


    Console.WriteLine($"quais as medidas dos 1° lado?");
    lado1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"quais as medidas dos 2° lado?");
    lado2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"quais as medidas dos 3° lado?");
    lado3 = int.Parse(Console.ReadLine());



    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine($"Ele e uma triangulo Equilatero, com 3 lados iguais");

    }
    else if (lado1 != lado2 && lado2 != lado3)
    {
        Console.WriteLine($"ele e um triangulo Isoceles, com 3 lados diferentes");
    }

    else
    {
        Console.WriteLine($"Ele e um triangulo Isocele, com 2 lados iguais");
    }

}

void Desafio4 ()
{
int senha = 1234;

Console.WriteLine("Digite a sua senha para verificarmos a validade. ");
senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO caso a senha seja válida. ");
    
}
else
{
    Console.WriteLine($"ACESSO NEGADO caso a senha seja inválida.");
    
}
}

void Desafio5 ()
{
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
}

void Desafio6 ()
{
int media = 7;
int frequência;

Console.WriteLine($"Digite sua media.");
media = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua frequencia.");
frequência = int.Parse(Console.ReadLine());

if (media >= 7 && frequência >= 80)
{
    Console.WriteLine($"APROVADO!!!!!!");
    
}
else if (media == 7 && frequência <= 75)
{
    Console.WriteLine($"O ALUNO NECESSITA FAZER RECUPERACAO!!!!");
    
}
else
{
   Console.WriteLine($"REPROVADO!!!");
    
}

}

void Desafio7 ()
{
int opcao;

do
{

    Console.Clear();

    Console.WriteLine($"-------------------------------------------------------------------------------");

    Console.WriteLine($"                               Bem vindo");
    Console.WriteLine($"                                   ao ");
    Console.WriteLine($"                             Jacareca Food");

    Console.WriteLine($"--------------------------------------------------------------------------------");

    Console.WriteLine($"");
    Console.WriteLine($"");

    Console.WriteLine($"---------------------------Escolha uma opção.------------------------------");
    Console.WriteLine($"1) hot roll --------------------------------------- R$ 25,00");
    Console.WriteLine($"2) Sushi ------------------------------------------ R$ 20,00");
    Console.WriteLine($"3) Temaki ----------------------------------------- R$ 25,00");
    Console.WriteLine($"4) Hot Temaki ------------------------------------ R$ 30,00 ");
    Console.WriteLine($"5) Yakisoba --------------------------------------- R$ 37,00");
    Console.WriteLine($"6) Onigiri ----------------------------------------- R$10,00");
    Console.WriteLine($"7) Tempura ---------------------------------------- R$ 20,00");
    Console.WriteLine($"");


    Console.WriteLine($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Saindo();
            Console.ReadLine();
            break;

        case 1:
            HotRoll();
            break;

        case 2:
            Sushi();
            break;

        case 3:
            Temaki();
            break;

        case 4:
            HotTemaki();
            break;

        case 5:
            Yakisoba();
            break;

        case 6:
            Onigiri();
            break;

        case 7:
            Tempura();
            break;

        default:
            break;


    }
} while (opcao != 0);

void HotRoll ()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot roll ");

}


void Sushi ()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Sushi ");

}


void Temaki ()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Temaki ");

}


void HotTemaki ()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot Temaki ");

}


void Yakisoba ()
{
            Console.WriteLine($"Boa escolha, vamos preparar seu Yakisoba ");
}


void Onigiri ()
{
            Console.WriteLine($"Boa escolha, vamos preparar seu Onigiri ");

}


void Tempura ()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Tempura ");

}


void Saindo ()
{
            Console.WriteLine($"Saindo... ");
    
}

}
