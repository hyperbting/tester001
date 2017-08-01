using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestClass41()
        {
            Class4<int> c4 = new Class4<int>(1);
            //1
            Console.WriteLine(c4.Count() + ") " + c4.ToString());
            c4.Add(2);//1 2
            Console.WriteLine(c4.Count() + ") " + c4.ToString());
            c4.Add(2);//1 2 2
            Console.WriteLine(c4.Count() + ") " + c4.ToString());
            c4.Remove(1);//2 2
            Console.WriteLine(c4.Count() + ") " + c4.ToString());
            c4.Remove(2);//2
            Console.WriteLine(c4.Count() + ") " + c4.ToString());
            c4.Remove(3);//2 //nothing to remove
            Console.WriteLine(c4.Count() + ") " + c4.ToString());
        }

        [TestMethod]
        public void TestClass4RemoveAt()
        {
            int temp;
            Class4<int> c4 = new Class4<int>(1);
            c4.Add(2);
            c4.Add(3);
            temp = c4.RemoveAt(5);//1 2 3 //nothing to remove
            Console.WriteLine(temp + ") " + c4.ToString());

            temp = c4.RemoveAt(1);//1 3
            Console.WriteLine(temp + ") " + c4.ToString());

            temp = c4.RemoveAt(3);//1 3 //nothing to remove
            Console.WriteLine(temp + ") " + c4.ToString());

            temp = c4.RemoveAt(0);//3
            Console.WriteLine(temp + ") " + c4.ToString());

            temp = c4.RemoveAt(0);//
            Console.WriteLine(temp + ") " + c4.ToString());

            temp = c4.RemoveAt(0);//
            Console.WriteLine(temp + ") " + c4.ToString());

            temp = c4.RemoveAt(0);//
            Console.WriteLine(temp + ") " + c4.ToString());
        }
    }
}
