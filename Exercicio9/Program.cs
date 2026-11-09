/*
EXERCICIO 9-faça um programa que receba o valor de 3 lados de um triangulo, e informe o tipo do triangulo: equilatero, isoceles e escaleno
OBS-os lados informados devem formar um triangulo(pesquisar).
*/

double lado1;
double lado2;
double lado3;

Console.WriteLine("Digite um lado do triangulo: ");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite outro lado do triangulo: ");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite mais um lado do triangulo: ");
lado3 = double.Parse(Console.ReadLine());

if ((lado1 + lado2) > lado3 && (lado1 + lado3) > lado2 && (lado2 + lado3) > lado1)
{
    Console.WriteLine("Os lados digitados formam um triangulo");
    if (lado1 == lado2 && lado1 == lado3)
    {
        Console.WriteLine("Triangulo Equilatero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("Triangulo Isoceles");
    }
    else
    {
        Console.WriteLine("Triangulo Escaleno");
    }
}
else
{
    Console.WriteLine("Os lados digitados NÃO formam um triangulo, digite dados válidos");
}

