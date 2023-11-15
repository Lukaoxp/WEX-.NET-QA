using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores_Aritméticos.Models
{
    public class Calculadora
    {
        public Calculadora(int v1, int v2)
        {
            a = v1;
            b = v2;
        }

        public int a { get; set; }
        public int b { get; set; }

        public void Somar(){
            System.Console.WriteLine(a + b);
        }
        public void Subtrair(){
            System.Console.WriteLine(a - b);
        }
        public void Multiplicar(){
            System.Console.WriteLine(a * b);
        }
        public void Dividir(){
            System.Console.WriteLine(a / (double)b);
        }
        public void Potencia(int a, int b){
            System.Console.WriteLine(Math.Pow(a, b));
        }
        public void RaizQuadrada(int a){
            System.Console.WriteLine(Math.Sqrt(a));
        }
    }
}