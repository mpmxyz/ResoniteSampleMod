using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeyLoader.Patching;
using System;

namespace SampleMod
{
    [TestClass]
    public class UninitializedModTest
    {
        [TestMethod]
        public void TestModHasNonEmptyName()
        {
            var mod = SampleModMonkey.Instance;
            Assert.IsNotNull(mod.Name);
            Assert.AreNotEqual("", mod.Name);
        }
    }
}
