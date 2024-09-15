using Tyuiu.BrovkinAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BrovkinAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алексей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Алексей", res);
        }
    }
}