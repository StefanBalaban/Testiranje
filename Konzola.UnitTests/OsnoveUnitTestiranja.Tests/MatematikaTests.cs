using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Konzola.OsnoveUnitTestiranja;

namespace Konzola.UnitTests.OsnoveUnitTestiranja.Tests
{
    [TestFixture]
    class MatematikaTests
    {
        private Matematika _matematika;
        [SetUp]
        public void Setup()
        {
            _matematika = new Matematika();
        }
        [Test]
        public void Saberi_Pozvan_VracaZbirParametara()
        {           
            var result = _matematika.Saberi(1, 2);

            Assert.That(result == 3);
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(0, 1, 1)]
        [TestCase(0, 0, 0)]
        public void Veci_Pozvan_VracaVeciParametar(int a, int b, int ocekivaniRezultat)
        {
            var result = _matematika.Veci(a, b);

            Assert.That(result == ocekivaniRezultat);
        }        
    }
}
