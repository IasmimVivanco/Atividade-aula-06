// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano atual:");
int ano = int.Parse(Console.ReadLine());

int anoDoNascimento = ano - idade;

Console.WriteLine($"Olá, {nome} você nasceu em {anoDoNascimento}");