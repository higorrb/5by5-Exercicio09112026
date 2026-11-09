/*EXERCICIO 7- faça um programa q receba o peso em kg e altura em cm de uma pessoa e calcule o imc.
Com base no resultado exiba a faixa correspondente(pesquisar).*/
float peso;
float altura;
float imc;

Console.WriteLine("Digite o peso(Kg): ");
peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura(cm): ");
altura = float.Parse(Console.ReadLine());

altura = altura / 100;

imc = peso / (altura * altura);

Console.WriteLine("seu IMC é: " + imc);
if (imc >= 30)
{
    Console.WriteLine("Obesidade");
}
if (imc <= 29.99 && imc >=25.0)
{
    Console.WriteLine("Sobrepeso");
}
if (imc <= 24.99 && imc >= 18.5)
{
    Console.WriteLine("Peso Normal");
}
if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}


