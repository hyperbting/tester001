using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestFindTheThLargest()
        {
            Class2 c2 = new Class2();
            for (int i = 1; i < 10; i++)
                Console.WriteLine(c2.FindTheThLargest(i));

        }
    }
}
