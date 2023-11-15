using Desconstrutor.Models;

Pessoa p = new Pessoa("Lucas", "Carturani");

(string nome, string sobrenome) = p;

System.Console.WriteLine(nome + " " + sobrenome);