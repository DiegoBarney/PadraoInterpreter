using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Soma : Expressao
    {
        private Expressao esquerda;
        private Expressao direita;

        public Soma(Expressao esquerda, Expressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public double avalia()
        {
            return esquerda.avalia() + direita.avalia();
        }
    }
}
