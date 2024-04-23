using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class ClassLibraryTests
    {
        [TestMethod]
        public void TestDiagonalProduct_WithPositiveDiagonals_ReturnsExpectedResult()
        {
            double[,] values = new double[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            ClassLibrary1 matrix = new ClassLibrary1(values);
            int[] diagonals = new int[] { 0, 1 };

            double result = matrix.Diagonal(diagonals);

            Assert.AreEqual(540, result);
        }

        [TestMethod]
        public void TestDiagonalProduct_WithNegativeDiagonals_ReturnsExpectedResult()
        {
            double[,] values = new double[,]
            {
                { -1, -2, -3 },
                { -4, -5, -6 },
                { -7, -8, -9 }
            };
            ClassLibrary1 matrix = new ClassLibrary1(values);
            int[] diagonals = new int[] { -1, -2 };

            double result = matrix.Diagonal(diagonals);

            Assert.AreEqual(-224, result);
        }

        [TestMethod]
        public void TestDiagonalProduct_WithZeroDiagonals_ReturnsExpectedResult()
        {
            double[,] values = new double[,]
            {
                { 0, 1, 2 },
                { 3, 0, 4 },
                { 5, 6, 0 }
            };
            ClassLibrary1 matrix = new ClassLibrary1(values);
            int[] diagonals = new int[] { 0, -1 };

            double result = matrix.Diagonal(diagonals);

            Assert.AreEqual(0, result);
        }
    }
}
