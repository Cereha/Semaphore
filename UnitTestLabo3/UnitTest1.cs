using Labo3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLabo3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new Program();
            Assert.AreEqual( test.Main() , 0 );
        }
        public void TestMethod2()
        {
            var test2 = new Program();
            Assert.AreEqual(test2.Main(), 0);
        }
        public void TestMethod3()
        {
            var test3 = new Program();
            Assert.AreEqual(test3.Main(), 0);
        }
    }
}
