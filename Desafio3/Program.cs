//Escreva     um     programa que leia     as     medidas     dos     lados     de    
//  um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

//− Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//− Triângulo    Isóscele:    possui    2    lados    iguais.     
// − Triângulo    Escaleno:    possui    3    lados    diferentes.


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
    else if (lado1 != lado2 && lado2 != lado3) {
        Console.WriteLine($"ele e um triangulo Isoceles, com 3 lados diferentes");
    } 
    
    else {
    Console.WriteLine($"Ele e um triangulo Isocele, com 2 lados iguais");
}
    
    //digite os valores dos lados do triangulo

    //verica se os lados sao iguais -> Equilátero
    //se nao for -> Escaleno

    





