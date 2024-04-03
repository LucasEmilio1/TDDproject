using System.Security.Cryptography.X509Certificates;
using TDDproject;

namespace SomaTest
{
    [TestClass]
    public class SomaTest
    {
        [TestMethod]
        public void CalcularSomaTest()
        {
            
             float num1 = 5;
             float num2 = 45;
             calculadoraSoma calculadora = new calculadoraSoma();

             float soma = calculadora.Soma(num1, num2);

             Assert.AreEqual(50, soma);
            
        }
    }
}