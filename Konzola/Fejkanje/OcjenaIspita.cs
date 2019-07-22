using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.Fejkanje
{
    public class OcjenaIspita
    {
        private IBazaPolozenih _bazaPolozenih;
        public OcjenaIspita(IBazaPolozenih bazaPolozenih)
        {
            _bazaPolozenih = bazaPolozenih;
        }
        public string OcjeniIspit(Ispit ispit)
        {
            if (Polozen(ispit.Ocjena))
            {
                ispit.Polozio = true;
                UnesiIspit(ispit);
                return "Položen";
            }
                
            return "Pao";
        }
        private bool Polozen(int ocjena)
        {
            if (ocjena > 5)
                return true;
            return false;
        }
        private void UnesiIspit(Ispit ispit)
        {            
            _bazaPolozenih.UnesiPolozenIspit(ispit);
            _bazaPolozenih.SpasiBazuPodataka();
        }
    }
}
