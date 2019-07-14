using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC200_Module01
{

    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();


            MyClass obj = new MyClass();
            //obj.Z;

            MyNamespace.Core.v2.MyClass obj2 = new MyNamespace.Core.v2.MyClass();
            // obj2.

            var x = 3.5;

            StringBuilder myStr = new StringBuilder();

            int i = 1;
            Console.WriteLine(i++);
            Console.WriteLine(i);

            int yy = 7;
            switch(yy)
            {
                case 1:
                    {
                        Console.WriteLine("menu option 1");
                        goto case 2;//break;
                    }
                case 2:
                    {
                        Console.WriteLine("menu option 1");
                        break;
                    }
            }

            for(int p=0;p<10; p++)
                Console.WriteLine(p);

            //while(true)
            //    Console.WriteLine("neverending");

            //for(; ; )
            //    Console.WriteLine("neverending");
        }

    }
    
    class MyClass
    {
        public String Z { get; set; }
    }
}

namespace MyNamespace.Core.v2
{
    namespace NestedNamespace
    {

    }
    class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
