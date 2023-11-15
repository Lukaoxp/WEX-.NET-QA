using Tuplas.Models;

(int id, string nome, string sobrenome) tupla = (12, "lucas", "Carturani");

//ValueTuple<int, string, string> outroExemploTupla = (12, "lucas", "Carturani");

var outroExemploTuplaCreate = Tuple.Create(12, "lucas", "Carturani");

System.Console.WriteLine(tupla.id);
System.Console.WriteLine(tupla.nome);
System.Console.WriteLine(tupla.sobrenome);

LeituraArquivo ler = new LeituraArquivo();

//var (Sucesso, LinhasArquivo, QtLinhas) = ler.LerArquivo("./Arquivos/Teste.txt");
var (Sucesso, LinhasArquivo, _) = ler.LerArquivo("./Arquivos/Teste.txt"); //descarta o uso de uma informação

if (Sucesso)
{
    Console.WriteLine(Sucesso);
    //Console.WriteLine(QtLinhas);
    for (int i = 0; i < LinhasArquivo.Count(); i++)
    {
        Console.WriteLine($"Linha {i + 1}: {LinhasArquivo[i]}");
    }
}
else
    Console.WriteLine("Erro");