//EXERCICIO 4- crie um programa q receba 2 numeros e execute as 4 operacoes matematicas basicas
float numero1;
float numero2;
char operador;

Console.WriteLine("Digite um numero: ");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite outro numero: ");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite um operador matematico: ");
operador = char.Parse(Console.ReadLine());

switch (operador)
{
    case '+': 
        Console.WriteLine(numero1 + numero2);
        break;

    case '-':
        Console.WriteLine(numero1 - numero2);
        break;

    case '*':
        Console.WriteLine(numero1 * numero2);
        break;

    case '/':
        Console.WriteLine(numero1 / numero2);
        break;

    default:
        Console.WriteLine("tente outro operador");
        break;


}