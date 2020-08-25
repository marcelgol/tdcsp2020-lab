using Calculator.Business;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestFixture]
    public class DegreeConverterTests
    {
        [Test]
        public void ToFahrenheit_ZeroCelsius_Returns32()
        {
            var converter = new DegreeConverter();
            decimal result = converter.ToFahrenheit(0);

            Assert.That(result, Is.EqualTo(32));
        }

  

        [Test]
        public void ToCelsius_105Fahrenheit_Returns4056()
        {
            var converter = new DegreeConverter();
            decimal result = converter.ToCelsius(105);

            Assert.That(result, Is.EqualTo(40.56));
        }
    }
}
