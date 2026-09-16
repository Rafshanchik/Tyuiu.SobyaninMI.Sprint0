using Tyuiu.SobyaninMI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SobyaninMI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Михаил";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Михаил", res);
        }
    }
}