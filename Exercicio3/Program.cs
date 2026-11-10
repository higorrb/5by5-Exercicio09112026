/*EXERCICIO 3-faça m programa q receba 4 notas de 1 alno, calcule a media aritmetica e informe os status do aluno
baseado nas seguintes condicoes:
	aprovado se a media maior ou igual a 7
	recuperacao se a media for entre 5.1 a 6.9
	reprovado se a media menor ou igual a 5
*/
float nota1;
float nota2;
float nota3;
float nota4;
float media;

Console.WriteLine("Digite sua PRIMEIRA nota: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua SEGUNDA nota: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua TERCEIRA nota: ");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua QUARTA nota: ");
nota4 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Sua media das 4 notas foi {media:F2}" );