using NUnit.Framework;

namespace ReportPortalDemo
{
    [TestFixture]
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(4, calc.Add(2, 2));
        }
    }
}
