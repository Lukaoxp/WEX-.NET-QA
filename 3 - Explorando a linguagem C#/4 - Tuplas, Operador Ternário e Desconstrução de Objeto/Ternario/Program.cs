using System.ComponentModel;

int i = 2;
bool par = false;

par = i % 2 == 0;
System.Console.WriteLine($"O numero {i} é " + (par ? "par" : "impar"));