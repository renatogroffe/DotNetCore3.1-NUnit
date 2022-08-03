using NUnit.Framework;

namespace Temperatura.Testes
{
    public class Tests
    {
        [TestCase(32, 0)]
        [TestCase(86, 30)]
        [TestCase(90.5, 32.5)]
        [TestCase(212, 100)]
        public void TesteConversaoTemperatura(
            double tempFahrenheit, double tempCelsius)
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(tempFahrenheit);
            Assert.AreEqual(tempCelsius, valorCalculado);
        }
    }
}
// testsssss