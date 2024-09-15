using Tyuiu.BrovkinAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BrovkinAA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedAdditionlValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void ChekedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void ChekedDivisionValid()
        {
            Assert.AreEqual(7, DataService.Division(21, 3));
            Assert.AreEqual(-1, DataService.Division(3, 0));
        }

        [TestMethod]
        public void ChekedMultiplicationValid()
        {
            Assert.AreEqual(130, DataService.Multiplication(13, 10));
        }
    }
}