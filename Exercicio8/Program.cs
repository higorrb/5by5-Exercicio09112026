/*
EXERCICIO 8- faça um programa que baseado no salario informado calcule o aumento salarial de acordo cm as regras a seguir:
	ate 2000, aumento de 15%
	entre 2000.01 e 4000, aumento de 10%
	acima de 4000, aumento de 5%*/
double salario;

Console.WriteLine("Digite um salário: R$");
salario = double.Parse(Console.ReadLine());

if(salario > 4000)
{
    salario = salario * 1.05;
    Console.WriteLine("Aumento de 5%: " + salario);
}
else if (salario >= 2000.01 && salario <= 4000)
{
    salario = salario * 1.10;
    Console.WriteLine("Aumento de 10%: " + salario);
}
else if (salario >= 0.01 && salario <= 2000)
{
    salario = salario * 1.15;
    Console.WriteLine("Aumento de 15%: " + salario);
}

Console.ReadKey();