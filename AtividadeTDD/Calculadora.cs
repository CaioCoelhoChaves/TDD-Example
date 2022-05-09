using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTDD
{
    public class Calculadora
    {
        public int Diferenca(int a, int b)
        {
            return a - b;
        }

        public int Divisao(int a, int b)
        {
            return a / b;
        }

        public int Produto(int a, int b)
        {
            return a * b;
        }

        public int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
