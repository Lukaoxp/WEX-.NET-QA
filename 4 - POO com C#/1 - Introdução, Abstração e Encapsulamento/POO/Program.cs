using POO.Models;

Pessoa p1 = new Pessoa
{
    Nome = "Mario",
    Idade = 12
};
p1.Apresentar();

////////// ENCAPSULAMENTO
ContaCorrente c1 = new ContaCorrente(122, 1000);

c1.Sacar(1200);
c1.SaldoAtual();


