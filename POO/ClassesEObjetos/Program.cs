using ClassesEObjetos;

Console.Clear();

// Console.WriteLine($"=== Agencia Bancaria ===");
// Console.WriteLine();

// AgenciaBancaria ContaDoWill = new AgenciaBancaria();

// ContaDoWill.Titular = "Will Graham";
// ContaDoWill.Saldo = 10.000f;


// ContaDoWill.Depositar(500);


// ContaDoWill.Sacar(1400);

ProdutoComDesconto Panela = new ProdutoComDesconto();

Panela.Nome = "Panela Anti aderente vermelha";

Panela.Preco = 200;

Console.WriteLine($"{Panela.Nome} custa R${Panela.Preco}");

Panela.AplicarDesconto(50);

Console.WriteLine($"Porem com desconto fica: R${Panela.Preco}");
