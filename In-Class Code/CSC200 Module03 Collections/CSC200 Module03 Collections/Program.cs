using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CSC200_Module03_Collections;

namespace MyVeryOwnNamespace
{
    public class C
    {
        public void f()
        {
            Point myPoint = new Point();
            myPoint.x = 10;
        }
    }
}
namespace CSC200_Module03_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(new Student("Alice", "CS"));
            myList.Add(new Student("Bob", "Art"));
            myList.Add(new Student("Charlie", "ME"));
            myList.Add(new Student("David", "History"));
            myList.Add(new Student("Chad", "Pre-Law"));

            //foreach (Student st in myList)
            //{
            //    Console.WriteLine(st);
            //}

            var myQuery = from Student st in myList
                          where st.Name == "Chad"
                select st;

            foreach (var st in myQuery)
            {
                Console.WriteLine(st);
            }


            Point myPoint = new Point();
            myPoint.x = 10;

        }        
    }

    class Point
    {
        internal int x;
        int y;
    }

    struct Student
    {
        public string Name { get; set; }
        public string Major { get; set; }

        public Student(string name, string Major)
        {
            Name = name;
            this.Major = Major;
        }

        public override string ToString()
        {
            return Name+ " : "+Major;
        }
    }
}
