using Konzola.OsnoveUnitTestiranja;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.UnitTests.OsnoveUnitTestiranja.Tests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(1, "1")]
        public void GetOutput_Pozvana_VratiString(int broj, string str)
        {
            var result = FizzBuzz.GetOutput(broj);

            Assert.That(result, Is.EqualTo(str));
        }
    }
}
