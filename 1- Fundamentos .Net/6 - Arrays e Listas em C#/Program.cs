// LISTAS

List<int> lista = new List<int>();

for (int i = 0; i < 10; i++){
    lista.Add(i * 2);
}

foreach (int i in lista) { 
    System.Console.WriteLine(i);
}
System.Console.WriteLine($"Quantidade na lista {lista.Count}, capacidade = {lista.Capacity}");

lista.Add(150);
lista.Add(250);

System.Console.WriteLine($"Quantidade na lista {lista.Count}, capacidade = {lista.Capacity}");

lista.Remove(2);
lista.Remove(0);

System.Console.WriteLine($"Quantidade na lista {lista.Count}, capacidade = {lista.Capacity}");

for (int i = 0; i < lista.Count; i++) { 
    System.Console.WriteLine($"Com count {lista[i]}");
}



////////////////////////////////////////////////////////////////
/// ARRAY
// int[] inteiros = new int[4];

// inteiros[0] = 10;
// inteiros[1] = 20;
// inteiros[2] = 30;
// inteiros[3] = 40;

// // for (int i = 0; i < inteiros.Length; i++){
// //     System.Console.WriteLine($"Posição {i} = {inteiros[i]}");
// // }

// int[] inteiros2 = new int[inteiros.Length * 2];

// foreach (int i in inteiros){
//     System.Console.WriteLine($"Posição {Array.IndexOf(inteiros,i)} = {i}");
// }
// foreach (int i in inteiros2){
//     System.Console.WriteLine($"Posição inteiros2 {Array.IndexOf(inteiros2,i)} = {i}");
// }


// Array.Copy(inteiros, inteiros2, inteiros.Length);

// foreach (int i in inteiros2){
//     System.Console.WriteLine($"Posição inteiros2 {Array.IndexOf(inteiros2,i)} = {i}");
// }

// // alterar tamanho de array
// Array.Resize(ref inteiros, 10);