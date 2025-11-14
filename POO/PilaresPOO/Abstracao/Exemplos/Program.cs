using Exemplos;

// Gato Bisteca = new Gato(); 

// Cachorro Nina = new Cachorro();

// Pessoa Hamilton = new Pessoa();

Console.Clear();

Console.WriteLine($"______________ CONTA CORRENTE _________________");
 ContaCorrente cc = new ContaCorrente(10);

Console.WriteLine($"Saldo inicial da conta: R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos transferencia: R${cc.Saldo}");
cc.Sacar(10);
Console.WriteLine($"Saldo apos saque: R${cc.Saldo}");


Console.WriteLine($"______________ CONTA POUPANCA _________________");

 ContaPoupanca cp = new ContaPoupanca(10);

Console.WriteLine($"Saldo inicial da conta: R${cp.Saldo}");
cp.Depositar(0.5);
Console.WriteLine($"Saldo apos transferencia: R${cp.Saldo}");
cp.Sacar(10.01);
Console.WriteLine($"Saldo apos saque: R${cp.Saldo}");
