using Konzola.Fejkanje;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.UnitTests.Fejkanje.Tests
{
    [TestFixture]
    class OcjenaIspitaTests
    {
        [Test]
        public void OcjeniIspit_OcjenaVecaOdPet_UnesenUBazu()
        {
            var bazaPolozenih = new Mock<IBazaPolozenih>();
            var ispit = new Ispit("Stefan", 6);
            var ocjenaIspita = new OcjenaIspita(bazaPolozenih.Object);

            ocjenaIspita.OcjeniIspit(ispit);

            bazaPolozenih.Verify(x => x.UnesiPolozenIspit(ispit));            
        }
    }
}
