using Labo3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace UnitTestLabo3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            Assert.AreEqual(Program.Main() , 0 );
        }
    }
}
