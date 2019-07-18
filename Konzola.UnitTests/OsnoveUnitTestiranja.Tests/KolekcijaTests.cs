using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Konzola.OsnoveUnitTestiranja;
using System.Linq;

namespace Konzola.UnitTests.OsnoveUnitTestiranja.Tests
{
    [TestFixture]
    class KolekcijaTests
    {
        [Test]
        public void Kolekcija_Pozvana_VratiKolekcijuDoVelicine()
        {
            var kolekcija = new Kolekcija();

            var result = kolekcija.KolekcijaNeparnihIntegera(5);

            Assert.That(result, Is.EquivalentTo(new int[] { 1, 3}));
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
            Assert.That(result, Is.Not.Null);
        }
    }
}
