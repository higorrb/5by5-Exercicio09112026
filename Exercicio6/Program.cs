/*EXERCICIO 6-faça um programa q leia a idade de uma pessoa e classifique de acord com as regras:
	crianças ate 12 anos
	adolescentes 13 ate 17 anos
	adulto de 18 a 59 anos
	idoso 60 ou mais
*/
int idade;

Console.WriteLine("Digite uma idade: ");
idade = int.Parse(Console.ReadLine());

if (idade > 60)
{
	Console.WriteLine("Pessoa idosa");
}
else if (idade <= 59 && idade >= 18)
{
	Console.WriteLine("pessoa adula");
}
else if (idade <= 17 && idade >= 13)
{
    Console.WriteLine("pessoa adolescente");
}
else if (idade <= 12 && idade >= 0)
{
    Console.WriteLine("pessoa criança");
}
