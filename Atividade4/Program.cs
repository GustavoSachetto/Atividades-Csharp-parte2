try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch (FileNotFoundException ex) // Exceção especifica
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
} 
catch (DirectoryNotFoundException ex) // Exceção especifica
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
} 
catch (Exception ex) // Exceção genérica
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally {
    Console.WriteLine("Chegou até aqui.");
}

throw new Exception("Ocorreu ua exceção"); // Cria uma nova exceção