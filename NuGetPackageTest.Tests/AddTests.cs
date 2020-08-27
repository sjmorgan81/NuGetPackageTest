namespace NuGetPackageTest.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void TwoPlusTwoEqualsFour()
        {
            Assert.AreEqual(Foo.Add(2, 2), 4);
        }

        [TestMethod]
        public void NPlusZeroEqualsN()
        {
            Assert.AreEqual(Foo.Add(1, 0), 1);
        }
    }
}
