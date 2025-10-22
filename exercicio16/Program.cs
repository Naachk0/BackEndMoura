/*Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo,
disposto na tabela abaixo:
Cargo            / % Aumento
Produção        / 6.5
Administrativo / 7.5
Diretoria     /12
De acordo com a tabela acima faça um programa que receba o cargo e o salário de
um funcionário e calcule e imprima o salário reajustado.*/


//salario = salario * 1.65

double salario, salarioNovo;
string cargo;

Console.WriteLine("qual o seu cargo? ");
cargo = Console.ReadLine();

Console.WriteLine("qual o seu salario? ");
salario = double.Parse(Console.ReadLine());

Console.Clear();
if (cargo == "produção")
{
    salarioNovo = salario * 1.065;
}
else if (cargo == "administrativo")
{
     salarioNovo = salario * 1.075;

} else {
  
  salarioNovo = salario * 1.012; 

}

Console.WriteLine($"o salario reajustado agora é {salarioNovo}");
