using System;
using System.Threading;

namespace Labo3
{
    public class Program
    {
        public static Semaphore _semaphore = new Semaphore(3, 3, "Labo3");
        public  int Main()
        {
            if (_semaphore.WaitOne(1000))
            {
                Console.WriteLine("IM Alive");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                _semaphore.Release();
                _semaphore.Dispose();
                return 0;
            }
            else
            {
                Console.WriteLine("Cannot obtain semaphore");
                return -1;
            }
        }
    }
}
