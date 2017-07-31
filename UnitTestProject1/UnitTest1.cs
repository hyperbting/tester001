using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArithmeticProgression()
        {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.ArithmeticProgression());
        }
        [TestMethod]
        public void TestFractionSum()
        {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.FractionSum());
        }
        [TestMethod]
        public void TestArithmeticProgressionVar()
        {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.ArithmeticProgressionVar());
        }
    }
}
