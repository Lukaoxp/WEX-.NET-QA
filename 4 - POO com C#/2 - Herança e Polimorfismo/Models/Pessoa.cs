using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Email { get; set; }

        public string Nome
        {
            get => _nome;
            set
            {
                if (value is string)
                {
                    _nome = value;
                }
            }
        }

        public int Idade
        {
            get => _idade; 
            set
            {
                    _idade = value;
            }
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}