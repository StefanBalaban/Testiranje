using Konzola.Fejkanje;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.UnitTests.Fejkanje.Tests
{
    [TestFixture]
    class KlasaSaStringovimaTests
    {
        [Test]
        public void VratiDuploStringovano_PozvanSaJedan_VratiDvaKaoString()
        {
            var klasaSaBrojevima = new Mock<IKlasaSaBrojevima>();
            klasaSaBrojevima.Setup(x => x.DuplirajBroj(1)).Returns(2);
            var klasaSaStringovima = new KlasaSaStringovima(klasaSaBrojevima.Object);

            var result = klasaSaStringovima.VratiDuploStringovano(1);

            Assert.That(result, Is.EqualTo("2"));
        }
    }
}
