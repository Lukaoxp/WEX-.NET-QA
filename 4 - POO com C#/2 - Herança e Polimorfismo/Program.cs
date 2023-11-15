using Models;

Pessoa p1 = new Pessoa
{
    Nome = "Mario",
    Idade = 12
};
p1.Apresentar();

Aluno a1 = new Aluno
{
    Nome = "Joao",
    Idade = 12,
    Nota = 8.0,
    Email = "joaogalo@gmail.com"
};
a1.Apresentar();

Professor p2 = new Professor
{
    Nome = "Julio",
    Idade = 42,
    Salario = 2000.0M
};
p2.Apresentar();