using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class RaizQuadrada : Expressao
    {
        private Expressao expressao;
        public RaizQuadrada(Expressao expressao)
        {
            this.expressao = expressao;

        }

        public double avalia()
        {
            return (int)Math.Sqrt(expressao.avalia());
        }
    }
}
