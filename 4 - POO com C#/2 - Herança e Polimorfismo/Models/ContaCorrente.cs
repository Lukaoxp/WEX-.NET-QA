using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            _saldo = saldoInicial;
        }
        public int NumeroConta{ get; set; }

        private decimal _saldo;

        public void Sacar(decimal valor){
            bool saldoSuficiente = _saldo >= valor;
            Console.WriteLine(saldoSuficiente ? "Saque realizado com sucesso" : "Saldo insuficiente");
            if (saldoSuficiente){
                _saldo -= valor;
            }
        }

        public void SaldoAtual(){
            Console.WriteLine(_saldo);
        }
    }
}