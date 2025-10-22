
int numero1, numero2;

Console.WriteLine("escolha o primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("escolha o segundo numero");
numero2 = int.Parse(Console.ReadLine());

Console.Clear();

if (numero1 > numero2) {
Console.WriteLine("o numero maior é: " + numero1);
}else if (numero2 > numero1){
        Console.WriteLine("o numero maior é: " + numero2);
} else{
     Console.WriteLine("Ambos sao iguais");};
