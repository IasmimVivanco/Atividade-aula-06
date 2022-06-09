// Atividade

string nomeDoUsuario;
int idadeDoUsuario;
int anoAtual = 2022;
int calcularAnoNascimento;


Console.WriteLine("Digite o seu nome:");
nomeDoUsuario = Console.ReadLine();

Console.WriteLine($"Olá, {nomeDoUsuario}! Seja bem-vindo ao cálculo do seu ano de nascimento!");

Console.WriteLine("Agora, digite a sua idade para prosseguirmos:");
idadeDoUsuario = Convert.ToInt32(Console.ReadLine()); //o ReadLine quando usado para capturar números você deve realizar a conversão.

calcularAnoNascimento = anoAtual
    - idadeDoUsuario; //cálculo básico para determinar ano de nascimento, subtraindo o ano atual pela idade do usuário.

Console.WriteLine($"Você nasceu em: {calcularAnoNascimento}");


//Desafio

int quilometrosPercorridosPeloVeiculo;
const float milhasPorKm = 0.621371f; //utilizei constante pois é um valor fixo. 
float conversao;

Console.WriteLine("Digite por inteiro quantos quilometros foram percorridos pelo seu veículo: ");
quilometrosPercorridosPeloVeiculo = Convert.ToInt32(Console.ReadLine());

conversao = quilometrosPercorridosPeloVeiculo * milhasPorKm;

Console.WriteLine($"Seu veículo percorreu um total de {conversao} milhas.");

