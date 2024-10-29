using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class class1
    {
        public class1()
        {
            Console.WriteLine("this is the class1 constuructor");
        }
        public void test1()
        {
            Console.WriteLine("this is a method1");
        }
        public void test2()
        {
            Console.WriteLine("this is method2");
        }


        class Class2 : class1
        {
            public Class2()
            {
                Console.WriteLine("this is class2 constructor");
            }
            public void test3()
            {
                Console.WriteLine("this is method3");
            }
            static void Main()
            {
                Class2 c = new Class2();
                c.test1(); c.test2(); c.test3();
                Console.ReadLine();
            }
        }

    }
}
