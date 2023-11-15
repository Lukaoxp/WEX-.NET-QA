using System;

namespace AnaliseDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a quantidade de testes bem-sucedidos:
      int testesBemSucedidos = int.Parse(Console.ReadLine());

      // Solicita ao usuário a quantidade de testes totais:
      int testesTotais = int.Parse(Console.ReadLine());

      // TODO: Implemente as condições para o cálculo da taxa de sucesso:
      double taxaSucesso = (double)testesBemSucedidos / testesTotais * 100;
      // TODO: Implemente uma estrutura condicional (if/else) para avaliar a taxa de sucesso e tomar decisões com base nela:
      Console.WriteLine(taxaSucesso >= 80 ? "A funcionalidade esta pronta para lancamento." : "A funcionalidade nao esta pronta para lancamento.");
    }
  }
}