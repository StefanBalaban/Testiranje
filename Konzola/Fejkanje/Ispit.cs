using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.Fejkanje
{
    public class Ispit
    {        
        public string Student { get; set; }
        public int Ocjena { get; set; }
        public bool Polozio { get; set; }

        public Ispit(string student, int ocjena)
        {
            Student = student;
            Ocjena = ocjena;
        }
    }
}
