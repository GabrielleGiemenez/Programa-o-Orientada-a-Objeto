using System;
using System.Collections.Generic;
using System.Text;

namespace Exercíco___ToString
{
    class Conversor
    {
        public static double Iof = 6;

        public static double ConversorProReal(double valor, double cotação)
        {
            double total = valor * cotação;
            return total + total * Iof / 100;
        }
    }
}
