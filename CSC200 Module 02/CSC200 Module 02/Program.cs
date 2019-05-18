using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC200_Module_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle myRectangle = new Rectangle();
            ////myRectangle.width = 2;
            ////myRectangle.height = 17;
            //Console.WriteLine("Area = "+myRectangle.GetArea());
            //Console.WriteLine(100);
            //Console.WriteLine("MSSA");

            //myRectangle.GetArea();

            //////////////////////////////////////////////////////
            int x = 10;
            int y = 1;
            Console.WriteLine("Before: x={0}, y={1}", x, y);
            Test.Swap(ref x, ref y);
            Console.WriteLine("After: x={0}, y={1}", x, y);

            Test.Method(1,true, "MSSA");
            Test.Method(1);
            Test.Method(1, false);
            //Test.Method(1, "MSSA");
            Test.Method(1, c: "MSSA");

            // int twice;
            // int squared;
            //Test.Method2(3, out twice, out squared);
            Test.Method2(3, out int twice, out int squared);
            Console.WriteLine(twice+ ", "+squared);

            try
            {
                ///int[] values = { };
                int[] values = {2,3,4,5,212,3,1 };
                Console.WriteLine(Test.FindMax(values));

                Debug.Assert(Test.FindMax(values) == 211);
            }
            //catch(ExecutionEngineException e) -- wrong type
            //catch (IndexOutOfRangeException e) -- right type
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) //-- the general type
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("ta da!");
        }
    }
    class Test
    {
        public static int FindMax(int[] arr)
        {
            if (arr.Length > 0)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                        max = arr[i];
                }

                return max;
            }
            else
            {
                throw new IndexOutOfRangeException("the array is empty!!!!!");
                Console.WriteLine("you'll never see me!");
            }
        }
        public static void Swap(ref int a, ref int b)
        {
            //Console.WriteLine("Before: a={0}, b={1}", a,b);
            int tmp = a;
            a = b;
            b = tmp;
            //Console.WriteLine("After: a={0}, b={1}", a, b);
        }

        public static void Method(int a, bool b=true, string c="MSSA")
        {

        }

        public static void Method2(int a, out int twiceA, out int squaredA)
        {
            twiceA = 2 * a;
            squaredA = a * a;
        }
    }


    class Rectangle
    {
        //data (fields and properties)
        public int height, width;

        private void DummyMethod()
        {

        }

        //methods (and event handlers ...)
        public int GetArea()
        {
            DummyMethod();
            return height * width;
        }

        //constructor
        public Rectangle(int newHeight , int newWidth = 0)
        {
            height = newHeight;
            width = newWidth;
        }
        

        public Rectangle()
        {
            height = 0;
            width = 0;
        }


    }

}
