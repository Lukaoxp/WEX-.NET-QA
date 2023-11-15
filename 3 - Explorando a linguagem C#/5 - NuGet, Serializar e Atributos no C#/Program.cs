using Models;
using Newtonsoft.Json;
/////// SERIALIZAÇÃO
/// Transformar objetos em fluxo de bytes para armazenamento ou transmissão
/// 

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritorio", 10.5M, DateTime.Now);
// Venda v2 = new Venda(2, "Licença de Software", 1500.0M, DateTime.Now);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas);

// File.WriteAllText("./Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


//// DESSERIALIZAÇÃO
///

// string arquivo = File.ReadAllText("./Arquivos/vendas.json");
// List<Venda2> listaVenda2 = JsonConvert.DeserializeObject<List<Venda2>>(arquivo);
// foreach (Venda2 venda in listaVenda2){
//     Console.WriteLine($"Id:{venda.Id} \nProduto: {venda.Produto} \nPreco: {venda.Preco} \nData: {venda.DataVenda:dd/MM/yyyy HH:mm}");
// }

//DESSERIALIZAÇÃO COM ATRIBUTOS DIFERENTES
string arquivo2 = File.ReadAllText("./Arquivos/vendas2.json");
List<Venda2> listaVenda3 = JsonConvert.DeserializeObject<List<Venda2>>(arquivo2);

foreach (Venda2 venda in listaVenda3){
    Console.WriteLine($"Id:{venda.Id} \nProduto: {venda.Produto} \nPreco: {venda.Preco} \nData: {venda.DataVenda:dd/MM/yyyy HH:mm}");
}