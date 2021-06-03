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
            Assert.AreEqual(Program.Main(), 0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Thread TestThread = new Thread(Program.Busy);
            TestThread.Start();
            Thread TestThread2 = new Thread(Program.Busy);
            TestThread2.Start();
            Thread TestThread3 = new Thread(Program.Busy);
            TestThread3.Start();
            Thread TestThread4 = new Thread(Program.Busy);
            TestThread4.Start();
            Assert.AreEqual(Program.Main(), -1);
        }
    }
}
