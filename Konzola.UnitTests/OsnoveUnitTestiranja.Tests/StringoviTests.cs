using Konzola.OsnoveUnitTestiranja;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.UnitTests.OsnoveUnitTestiranja.Tests
{
    [TestFixture]
    class StringoviTests
    {
        private Stringovi _stringovi;
        [SetUp]
        public void Setup()
        {
            _stringovi = new Stringovi();
        }
        [Test]
        public void Zagrade_Pozvan_SpecificanSlucaj()
        {
            var result = _stringovi.Zagrade("abc");

            Assert.That(result, Is.EqualTo("(abc)"));
        }
        [Test]
        public void Zagrade_Pozvan_GeneralanSlucajPocinjeSa()
        {
            var result = _stringovi.Zagrade("abc");

            Assert.That(result, Does.StartWith("("));
        }
        [Test]        
        public void Zagrade_Pozvan_GeneralanSlucajZavrsavaSa()
        {
            var result = _stringovi.Zagrade("abc");

            Assert.That(result, Does.EndWith(")"));
        }
        [Test]
        public void Zagrade_Pozvan_GeneralanSlucajSadrzi()
        {
            var result = _stringovi.Zagrade("abc");

            Assert.That(result, Does.Contain("ABC").IgnoreCase);
        }
    }
}
