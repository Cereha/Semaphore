using Labo3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace UnitTestLabo3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Semaphore _semaphore = new Semaphore(3, 3, "LAB3._3");
            var a =new Sem();
            int x;
            if (_semaphore.WaitOne(1000))
            {
                x = a.True();
                Console.WriteLine("IM Alive");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                _semaphore.Release();
                _semaphore.Dispose();
            }
            else
            {
                x = a.False();
                Console.WriteLine("Cannot obtain semaphore");
            }

             
            Assert.AreEqual( x , 0 );
        }
    }
}
