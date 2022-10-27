using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTestProject
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public void ThisIsMyTestMethod()
        {
            Assert.AreNotEqual(1, 2);
        }
    }
}
