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
            Assert.AreEqual(Program.Main() , 0 );
        }
        [TestMethod]
        public void TestMethod2()
        {
            while (Program.Main() != -1) {
                Thread TestThread;
                TestThread = new Thread(new ThreadStart(Program.Busy));
            }
            Assert.AreEqual(Program.Main(), -1);
        }
    }
}
