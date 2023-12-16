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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
            Console.WriteLine("Before Test!");
            Console.Out.Flush();

            var mod = MonkeyBase<SampleModMonkey>.Instance;
            Assert.IsNotNull(mod.Name);
            Assert.AreNotEqual("", mod.Name);
        }
    }
}
