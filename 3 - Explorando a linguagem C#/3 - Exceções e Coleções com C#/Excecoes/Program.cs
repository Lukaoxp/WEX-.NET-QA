using Excecoes.Models;


////////////// EXCECOES

new ExemploExcecao().Metodo1();

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (FileNotFoundException e)
{
    Console.WriteLine($"Arquivo não encontrado. {e.Message}");
}
catch (PathTooLongException e)
{
    Console.WriteLine($"Caminho muito longo. {e.Message}");
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine($"Pasta não encontrada. {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Excessão genérica. {e.Message}");
}
finally
{
    Console.WriteLine("Programa Finalizado");
}
