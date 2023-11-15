/////////////// DICTIONARY
///
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RJ", "Rio de janeiro");
estados.Add("SC", "Santa Catarina");
estados.Add("PR", "Paraná");
estados.Add("BA", "Bahia");

Printar();

estados.Remove("BA");
System.Console.WriteLine();
Printar();

void Printar()
{
    foreach (KeyValuePair<string, string> item in estados) 
    { 
        System.Console.WriteLine($"Chave: {item.Key}: {item.Value}"); 
    }
}

// /////////////// PILHA
// ///
// Stack<int> pilha = new Stack<int>();

// for (int i = 0; i < 5; i++)
// {
//     pilha.Push(Convert.ToInt32(Math.Pow(i + 1, 2)));
// }

// PrintPilha(pilha);
// pilha.Pop();
// System.Console.WriteLine();
// PrintPilha(pilha);

// void PrintPilha(Stack<int> pilha)
// {
//     foreach (var item in pilha)
//     {
//         System.Console.WriteLine($"item nº {pilha.ToList().IndexOf(item)} - {item}");
//     }
// }


// /////////////// FILA
// ///
// Queue<int> fila = new Queue<int>();

// for (int i = 0; i < 5; i++)
// {
//     fila.Enqueue(Convert.ToInt32(Math.Pow(i + 1, 2)));
// }

// PrintFila(fila);
// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}\n");
// PrintFila(fila);
// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}\n");
// PrintFila(fila);

// void PrintFila(Queue<int> fila)
// {
//     foreach (var item in fila)
//     {
//         System.Console.WriteLine($"item nº {fila.ToList().IndexOf(item)} - {item}");
//     }
// }