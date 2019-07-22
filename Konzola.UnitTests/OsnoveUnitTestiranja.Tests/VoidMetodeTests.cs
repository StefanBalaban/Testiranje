using Konzola.OsnoveUnitTestiranja;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.UnitTests.OsnoveUnitTestiranja.Tests
{
    [TestFixture]
    class VoidMetodeTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(100)]
        public void InkrementirajBrojac_PozvanJednom_BrojacJeJedan(int brojInkrementacija)
        {
            var voidMetode = new VoidMetode();

            for(int i = 0; i < brojInkrementacija; i++)
            {
                voidMetode.InkrementairajBrojac();
            }            

            Assert.That(voidMetode.Brojac, Is.EqualTo(brojInkrementacija));
        }
        [Test]
        public void SetNaziv_PozanSaStringom_NazivJednakStringu()
        {
            var voidMetode = new VoidMetode();

            voidMetode.SetNaziv("Novi");

            Assert.That(voidMetode.Naziv, Is.EqualTo("Novi"));
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void SetNaziv_PozvanSaInt_ThrowNewException(string naziv)
        {
            var voidMetode = new VoidMetode();

            Assert.That(() => voidMetode.SetNaziv(naziv), Throws.Exception);
        }
        [Test]
        public void ZaprimiString_PozvanSaStringom_PozoveEvent()
        {
            var voidMetode = new VoidMetode();
            var str = "";
            voidMetode.StringZaprimljen += (sender, args) => { str = args; };

            voidMetode.ZaprimiString("1");

            Assert.That(str, Is.EqualTo("1"));

        }
        [Test]        
        public void ZaprimiString_PozvanSaNull_PozoveEventKako()
        {
            var voidMetode = new VoidMetode();
            var str = "";
            voidMetode.StringZaprimljen += (sender, args) => { str = args; };

            voidMetode.ZaprimiString(null);

            Assert.That(str, Is.EqualTo(null));
        }
    }
}
