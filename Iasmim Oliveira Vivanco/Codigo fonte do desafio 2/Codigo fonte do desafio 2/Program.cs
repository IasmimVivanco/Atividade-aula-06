// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quantos quilômetros seu veiculo percorreu?");

float quilometrosPercorridosPeloVeiculo = int.Parse(Console.ReadLine());

float milhas = quilometrosPercorridosPeloVeiculo * 0.62f;

Console.WriteLine($"Seu veículo percorreu um total de {milhas} milhas.");