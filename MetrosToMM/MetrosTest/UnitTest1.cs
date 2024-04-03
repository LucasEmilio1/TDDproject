namespace MetrosTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class MetrosTest
    {
        [TestMethod]
        public void TestMetrosConversor()
        {
            // Arrange
            Metros conversor = new Metros();
            float metros = 2.5f;
            float esperado = 2500; // 2.5 metros = 2500 mil�metros

            // Act
            float resultado = conversor.Metrosconversor(metros);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001f, "A convers�o de metros para mil�metros est� incorreta.");
        }
    }
