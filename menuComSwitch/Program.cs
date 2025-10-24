
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










//hot roll
//temaki
//sushi
//yakisoba
// shimeji
//onigiri
//tempura

//Escolha uma opção no menu abaixo:

   //1) Opção 1
  // 2) Opção 2
  // 3) Opção 3
  // 0) Sair
