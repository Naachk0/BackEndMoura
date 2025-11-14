using Polimorfismo;

PagamentoPIX CompraPIX = new PagamentoPIX();
CompraPIX.ValorCompra = 5000;

float ValorPagar  = CompraPIX.CalcularTotal();

Console.WriteLine($"Produto: UP N DOWN album premium");
Console.WriteLine($"Preço: {CompraPIX.ValorCompra}");
Console.WriteLine($"Pagamento com desconto: {ValorPagar}");

Console.WriteLine($"");

PagamentoCartao CompraCartao = new PagamentoCartao();
CompraCartao.ValorCompra = 500;

Console.WriteLine($"Produto: Ganyu Genshin Impact Cosplay");
Console.WriteLine($"Pagamento com desconto: {CompraCartao.ValorCompra}");
Console.WriteLine($"Preço: {CompraCartao.ValorCompra}");
Console.WriteLine($"Pagamento com desconto: {CompraCartao.CalcularTotal()}");
