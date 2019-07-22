using Konzola.OsnoveUnitTestiranja;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.UnitTests.OsnoveUnitTestiranja.Tests
{
    [TestFixture]
    class ReturnTipTests
    {
        private ReturnTip _returnTip;
        [SetUp]
        public void Setup()
        {
            _returnTip = new ReturnTip();
        }
        [Test]
        public void GetTipVozila_PozvanSaNull_VratiKlasuTipAutomobil()
        {
            var result = _returnTip.GetTipVozila(null);

            Assert.That(result, Is.TypeOf<Automobil>());
        }
        [Test]        
        public void GetTipVozila_PozvanSaNMercedes_VratiKlasuTipMercedes()
        {
            var result = _returnTip.GetTipVozila("Mercedes");

            Assert.That(result, Is.TypeOf<Mercedes>());
        }
        [Test]
        public void GetTipVozila_PozvanSaGolf_VratiKlasuTipGolf()
        {
            var result = _returnTip.GetTipVozila("Golf");

            Assert.That(result, Is.InstanceOf<Volkswagen>());
        }
    }
}
