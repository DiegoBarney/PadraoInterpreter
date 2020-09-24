using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Numero : Expressao
    {
        private double numero;

        public Numero(double numero) {
            this.numero = numero;
        }

        public double avalia()
        {
            return this.numero;
        }
    }
}
