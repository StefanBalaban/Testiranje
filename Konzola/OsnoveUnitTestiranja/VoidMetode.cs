using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.OsnoveUnitTestiranja
{
    public class VoidMetode
    {
        public int Brojac { get; set; }
        public string Naziv { get; set; }
        public void InkrementairajBrojac()
        {
            Brojac++;
        }
        public void SetNaziv(string naziv)
        {
            if (String.IsNullOrEmpty(naziv))                
               throw new Exception();
            Naziv = naziv;
        }
        public event EventHandler<string> StringZaprimljen;
        public void ZaprimiString(string str)
        {
            StringZaprimljen.Invoke(this, str);
        }

        
    }
}
