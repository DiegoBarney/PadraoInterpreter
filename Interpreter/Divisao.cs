using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Divisao : Expressao
    {
        private Expressao esquerda;
        private Expressao direita;

        public Divisao(Expressao esquerda, Expressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public double avalia()
        {
            return esquerda.avalia() / direita.avalia();
        }
    }
}
