//EXERCICIO 2-escrva um programa q informe 2 numeros decimais e informe se eles sao maior, menor ou iguais 
float numero1;
float numero2;

Console.WriteLine("Digite um numero: ");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite outro numero: ");
numero2 = float.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("Primeiro numero maior q o segundo");
}
else if (numero1 < numero2)
{
    Console.WriteLine("Segundo numero maior q o primeiro");
}
else
{
    Console.WriteLine("numeros iguais");
}
