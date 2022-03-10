using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    public static class Calculadora
    {
        public static int Somar(int val1, int val2)
        {
            return val1 + val2;
        }

        public static int Somar(int val1, int val2, int val3)
        {
            return val1 + val2 + val3;
        }

        public static int Subtrair(int val1, int val2)
        {
            return val1 - val2;
        }

        public static int Subtrair(int val1, int val2, int val3)
        {
            return val1 - val2 - val3;
        }

        public static int Multiplicar(int val1, int val2)
        {
            return val1 * val2;
        }

        public static int Multiplicar(int val1, int val2, int val3)
        {
            return val1 * val2 * val3;
        }
    }
}
