using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC200_Module_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((FontType)7);

            //Student bob = new Student(1385, "Bob", "Arts");
            //bob.ID = 10;
            ////bob.courses
            //for(int i=0; i<bob.courses.Length;i++)
            //    Console.WriteLine(bob.courses[i]);

            //for (int i = 0; i < bob.courses.Length; i++)
            //    Console.WriteLine(bob[i]);


            //Student alice = new Student(5831, "Alice");
            //Student def = new Student();

            //Console.WriteLine(bob.ToString());
            //Console.WriteLine(alice.ToString());
            //Console.WriteLine(def.ToString());

            //byte x = 10, y = 20;
            //int sum = x + y;

            ////int? xy = 7;



            ////S emptyStruct = new S();
            ////Console.WriteLine(emptyStruct.x);
            ///



            ///////////////////////////
            ArrayList myList = new ArrayList();
            //myList.Add("carrots");
            //myList.Add("rope");
            //myList.Add("bleach");
            //myList.Add(123);
            myList.Add(new Student(1,"Bob"));
            myList.Add(new Student(3, "Alice", "Math"));
            myList.Add(new Student(7, "James", "CS"));
            //myList.Add("bleach");

            foreach (var item in myList)
                Console.WriteLine(((Student)item).ToString());
        }
    }

    //struct S
    //{
    //    public int x;
    //}

    //[Flags]
    enum FontType { Bold = 0x01, Italic = 0x02, Underline = 0x04, Strikeout = 0x08, ReverseItalic = 0x10 };

    struct Student
    {
        //fields
        private int id;
        public int ID { get { return id; } set { id = value; } }

        string name;
        internal string major;

        public string[] courses;

        //public int MyProperty;

        //constructor
        //public Student() //default constructor  - not allowed for struct
        //{
        //    id = 7;
        //}
        public Student(int id, string name, string newMajor = "undecided")
        {
            this.id = id;
            this.name = name;
            major = newMajor;
            courses = new string[]{ "CSC101", "CSC200", "CSC395" };
        }

        //methods
        public string ToString()
        {
            return id + ":" + name + ", has major: " + major;
        }

        public string this[int index]
        {
            get { return courses[index]; }
            set { courses[index] = value; }
        }
    }
}
