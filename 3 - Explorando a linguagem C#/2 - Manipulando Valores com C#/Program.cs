using System.Globalization;

string a = "abelha", 
b = "bola", 
c = "carro", 
d = "disco";
/// Concatenação de strings
/// 

Console.WriteLine(a + " " + b);
Console.WriteLine();

////////////////////////////////
///
/// Interpolação de strings
/// 
string texto = $"{c} {d}";
Console.WriteLine(texto);

////////////////////////////////
///
/// Ajuste de numeração
///
List<string> lista = new List<string>();
lista.Add(a);
lista.Add(b);
lista.Add(c);
lista.Add(d);
foreach (string s in lista){
    // Console.WriteLine($"String {lista.IndexOf(s)}: {s}"); //inicia em zero
    Console.WriteLine($"String {lista.IndexOf(s) +1}: {s}"); //adição de +1 para ajuste do valor, afim de não iniciar em zero
}
Console.WriteLine();

////////////////////////////////
///
/// Concatenação de valores
/// 
string num1 = "10";
string num2 = "20";

string resultado = num1 + num2;
Console.WriteLine($"{resultado}");

int num1int = int.Parse(num1);
resultado = num1int + num2; // caso um deles seja string, será concatenado.
Console.WriteLine($"{resultado}");

Console.WriteLine();

////////////////////////////////
///
/// Formatação de valores monetários
///
decimal valormonetario = 1782.40M;
Console.WriteLine($"{valormonetario:C}"); //Exibe com a moeda da regiao setada - C de Currency

Console.WriteLine();

////////////////////////////////
///
/// Localização de código
///
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"{valormonetario:C}"); //Exibe com a cultura informada dentro do codigo inteiro
Console.WriteLine();

////////////////////////////////
///
/// Localização da cultura
///
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
Console.WriteLine($"{valormonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}"); //Exibe com a cultura especifica informada
Console.WriteLine();

////////////////////////////////
///
/// Formatação personalizada
///
Console.WriteLine($"{valormonetario.ToString("C1")}"); //Exibe com a formatação com 1 casa decimal
Console.WriteLine($"{valormonetario.ToString("C5")}"); //Exibe com a formatação com 5 casas decimais
Console.WriteLine($"{valormonetario.ToString("N1")}"); //Exibe com a formatação com 1 casa decimal como numero
Console.WriteLine();

////////////////////////////////
///
/// Representando porcentagem
///
double porcentagem = .3421;
int numero = 123456;
Console.WriteLine($"{porcentagem.ToString("P")}");
Console.WriteLine();

////////////////////////////////
///
/// Formatação de digitos personalizada
///
Console.WriteLine($"{numero.ToString("##-##-##")}");
Console.WriteLine();

////////////////////////////////
///
/// DateTime
///
DateTime data = DateTime.Now; //Obtém data e horas atuais
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToString("dd 'de' MMMM 'de' yyyy"));

Console.WriteLine();

////////////////////////////////
///
/// Formatando Data e Hora
///
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

data = DateTime.Parse("15/10/2023 01:00");
Console.WriteLine(data);

Console.WriteLine();
////////////////////////////////
///
/// Datetime com tryparse
///
string dataString = "2023-10-15 01:00";
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
Console.WriteLine(dataString + " " + data);

Console.WriteLine();
////////////////////////////////
///
/// Validando retorno de TryParse
///
dataString = "2023-12-15 01:00";
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);

Console.WriteLine(sucesso? "Success" : "Error"); //Possivel ser escrito com If Ternario

if (sucesso)
{
    Console.WriteLine("Boa");
}
else
    Console.WriteLine("Ruim");