using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Multiplicacao : Expressao
    {
        private Expressao esquerda;
        private Expressao direita;

        public Multiplicacao(Expressao esquerda, Expressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public double avalia()
        {
            return esquerda.avalia() * direita.avalia();
        }
    }
}
