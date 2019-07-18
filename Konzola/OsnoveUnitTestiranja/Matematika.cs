using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.OsnoveUnitTestiranja
{
    public class Matematika
    {
        public int Saberi(int a, int b)
        {
            return a + b;
        }
        public int Veci(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
