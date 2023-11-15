using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Professor {Nome}, {Idade} anos e salário {Salario}");
        }
    }
}