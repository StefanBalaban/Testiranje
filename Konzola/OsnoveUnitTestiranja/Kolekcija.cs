using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.OsnoveUnitTestiranja
{
    public class Kolekcija
    {
        public IEnumerable<int> KolekcijaNeparnihIntegera(int velicina)
        {
            for (int i = 0; i < velicina; i++)
                if (i % 2 != 0)
                    yield return i;            
        }
    }
}
