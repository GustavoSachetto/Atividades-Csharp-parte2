using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-EU"); // Mudando a cultura do sistema (idioma / sistema monetario)

decimal dinheiro = 1999.23M;

Console.WriteLine($"Meu saldo é: {dinheiro:C}"); // Imprimir a variavel como valor monetario
 
// Formatar a variavel para valor monetario
Console.WriteLine(dinheiro.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

Console.WriteLine(dinheiro.ToString("C4")); // Almentando o numero de casas decimais para 4

double porcentagem = .4523;
Console.WriteLine(porcentagem.ToString("P")); // Formatando para porcentagem

int cep = 97855080;
Console.WriteLine(cep.ToString("##-###-###")); // Formatando inventando moda

DateTime data = DateTime.Now;
DateTime data1 = DateTime.Parse("29/04/2022 18:00");
string data2 = "31/02/1980";

DateTime.TryParseExact(data2, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3);

Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data1.ToString("MM"));
Console.WriteLine(data2);
Console.WriteLine(data3);
