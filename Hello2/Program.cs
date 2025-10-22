

Console.WriteLine("Hello, World!");
//pedir para o usuario digitar o nome,sobrenome, idade, saldo investimento

String nome;
String sobrenome;
int idade;
float saldoConta;
float investimento;

Console.WriteLine("Ola, qual o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual o seu sobrenome?");
sobrenome = Console.ReadLine();

Console.WriteLine("Qual a sua idade?");
idade  = int.Parse( Console.ReadLine() );

Console.WriteLine("Qual o seu saldo?");
saldoConta  = float.Parse( Console.ReadLine() );

Console.WriteLine("Quanto e o seu investimento?");
investimento = float.Parse(Console.ReadLine());


Console.Clear();

Console.WriteLine($"Nome: {nome} {sobrenome}");
Console.WriteLine($"idade do {nome} e {idade}");
Console.WriteLine($"Saldo Bancario: {saldoConta}");
Console.WriteLine($"investimento esse ano: {investimento}");


/*Console.WriteLine("Nome: " + nome);

Console.WriteLine("sobrenome: " + sobrenome);

Console.WriteLine("idade: " + idade);

Console.WriteLine("saldo Bancario:$ " + saldoConta);

Console.WriteLine("Seu investimento: " + investimento); */