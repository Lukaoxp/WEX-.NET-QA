using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

       public Pessoa(string v1, int v2)
        {
            Nome = v1;
            Idade = v2;
        }

        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}