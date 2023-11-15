using _1___Propriedades__Métodos_e_Construtores_em_C_.Models;

Pessoa p1 = new("Lucas", "ca", 29);
Pessoa p2 = new("Mario", "Bu", 30);
Pessoa p3 = new(sobrenome:"Mario", nome:"Bu");

Curso curso1 = new()
{
    Nome = "Ciencias",
    Alunos = new List<Pessoa>()
};

curso1.AdicionarAluno(p1);
curso1.AdicionarAluno(p2);
curso1.AdicionarAluno(p3);

curso1.ListarAlunos();