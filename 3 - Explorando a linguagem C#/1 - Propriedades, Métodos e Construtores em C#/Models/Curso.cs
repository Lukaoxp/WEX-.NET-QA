using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1___Propriedades__Métodos_e_Construtores_em_C_.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) => Alunos.Add(aluno);

        public void ObterQuantidadeDeAlunosMatriculados() => Console.WriteLine($"Existem {Alunos.Count()} inscritos no curso");

        public bool RemoverAluno(Pessoa aluno) => Alunos.Remove(aluno);

        public void ListarAlunos(){
            Console.WriteLine($"Curso: {Nome}");
            ObterQuantidadeDeAlunosMatriculados();
            foreach (Pessoa aluno in Alunos){
                Console.WriteLine($"Aluno nº {Alunos.IndexOf(aluno)+1}: {aluno.NomeCompleto} de {aluno.Idade} anos");
            }
        }
    }
}