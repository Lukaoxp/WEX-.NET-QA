using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desconstrutor.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();
            set { _nome = value; }
        }
        public string Sobrenome { get; set; }


    }
}