using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.OsnoveUnitTestiranja
{
    // Da bi testirali return tip neke metode koja vraća podklasu od tipa definisanog u potpisu
    // Treba nam jedna bazna klasa i jedna ili više podklasa
    // Ja ću definisati klasu Automobil kao baznu klasu
    // A Mercedes i Volkswagen kao podklase
    public class Automobil
    {

    }
    public class Mercedes : Automobil
    {

    }
    public class Volkswagen : Automobil
    {
    }
    // Ova podklasa služi da testiramo Is.InsanceOf metod na Volkwagen klasi
    public class Golf : Volkswagen
    {

    }
    public class ReturnTip
    {
        public Automobil GetTipVozila(string tip)
        {
            switch (tip)
            {
                case "Mercedes":
                    return new Mercedes();
                case "Golf":
                    return new Golf();
                default:
                    return new Automobil();
            }            
        }
    }
}
