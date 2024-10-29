using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    internal class ClassthreadDemo
    {
        Thread t1, t2, t3;
        public ClassthreadDemo()
        {
            t1 = new Thread(Display);
            t2 = new Thread(Display);
            t3 = new Thread(Display);
            t1.Start();
            t2.Start();
            t3.Start();
        }
        public void Display()
        {
            Console.WriteLine("C# is");
            Thread.Sleep(5000);
            Console.WriteLine("Object Oriented");
        }
        static void Main()
        {
            ClassthreadDemo obj = new ClassthreadDemo();
            obj.t1.Join();
            obj.t2.Join();
            obj.t3.Join();
        }
    }

}
