Console.Clear();

string especie, raca, nome, idade, pelagemCor;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("——————————————————");
Console.WriteLine("Pet Hotel - Check-in");
Console.WriteLine("——————————————————");
Console.ResetColor();

//Captura de dados
Console.Write("Digite a Espécie (Ex: Gato ou Cachorro): ");
especie = Console.ReadLine()!.Trim().ToUpper();

Console.Write("Qual a Raça: ");
raca = Console.ReadLine()!.Trim().ToUpper();

Console.Write("Nome: ");
nome = Console.ReadLine()!.Trim().ToUpper();

Console.Write("Idade: ");
idade = Console.ReadLine()!.Trim();

Console.Write("Pelagem/cor: ");
pelagemCor = Console.ReadLine()!.Trim().ToUpper();

Console.Clear();

// Exibição da ficha do pet
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("|—————————————————————————————————————————————————————————|");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Pet Hotel \"Nem um pio\"");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                  |");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("|—————————————————————————————————————————————————————————|");

Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(especie.PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(raca.PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("|—————————————————————————————————————————————————————————|");
Console.Write("| Atende pelo nome de: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(nome.PadLeft(34, '.').Substring(0, 34));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{idade.PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(pelagemCor.PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("|—————————————————————————————————————————————————————————|");

Console.ResetColor();