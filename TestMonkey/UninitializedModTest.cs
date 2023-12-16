using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeyLoader.Patching;

namespace SampleMod
{
    [TestClass]
    public class UninitializedModTest
    {
        [TestMethod]
        public void TestModHasNonEmptyName()
        {
            var mod = MonkeyBase<SampleModMonkey>.Instance;
            Assert.IsNotNull(mod.Name);
            Assert.AreNotEqual("", mod.Name);
        }
    }
}
