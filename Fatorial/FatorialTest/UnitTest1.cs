using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FatorialTest
{

    [TestClass]
    public class FatorialTest
    {
        [TestMethod]
        public void TestFatorial()
        {
            // Arrange
            int[] expectedFactorials = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800 };

            // Act & Assert
            for (int i = 0; i <= 10; i++)
            {
                int result = FatorialCalculator.CalcFato(f);
                Assert.AreEqual(expectedFactorials[i], result, $"Fatorial de {f} está incorreto.");
            }
        }
    }

}