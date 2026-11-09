//EXERCICIO 1-escreva um programa q recba um numero inteiro e informe se ele é par ou impar
int numero;

Console.WriteLine("Digite um numero: ");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0) {
    Console.WriteLine("numero PAR");
}
else
{
    Console.WriteLine("numero IMPAR");
}

