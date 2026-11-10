//Exercicio 5
//crie um programa q leia o ano informado pelo usuario e mostre se foi ou é um ano bisexto
int ano;

Console.WriteLine("Digite um ano: ");
ano = int.Parse(Console.ReadLine());


if (ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0)
{
    Console.WriteLine("É um ano bisexto");
}
else
{
    Console.WriteLine("Não é um ano bisexto");
}


