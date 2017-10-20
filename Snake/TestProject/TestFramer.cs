using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestFramer
    {
        Framer framer;

        [TestInitialize]
        public void Setup()
        {
            framer = new Framer();
        }

        [TestMethod]
        public void StartFramer()
        {
            Assert.IsNotNull(framer);
        }
    }
}
