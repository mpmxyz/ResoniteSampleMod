using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleMod
{
    [TestClass]
    public class ExampleUnitTest
    {
        [TestMethod]
        public void TestIncrement()
        {
            Assert.AreEqual(1, TestableCode.Increment(0));
        }
    }
}
