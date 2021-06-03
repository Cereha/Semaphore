using System;
using System.Threading;

namespace Labo3
{
    public class Program
    {
        public static Semaphore _semaphore = new Semaphore(3, 3, "Labo3");
        public static int Main()
        {
            if (_semaphore.WaitOne(1000))
            {
                Console.WriteLine("IM Alive");
                Console.WriteLine("Press any key");
                _semaphore.Release();
                Thread.Sleep(20000);
                _semaphore.Dispose();
                return 0;
            }
            else
            {
                Console.WriteLine("Cannot obtain semaphore");
                return -1;
            }
        }
        public static void Busy()
        {
            
            if (_semaphore.WaitOne(1000))
            {
                _semaphore.Release();
                Thread.Sleep(20000);
            }
            else
            {
                Console.WriteLine("Cannot obtain semaphore");
            }
        }
    }           
}
