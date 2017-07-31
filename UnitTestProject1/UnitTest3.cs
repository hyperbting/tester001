using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestRomanNumberSet()
        {
            RomanNumberSet rns = new RomanNumberSet("I","V");
            rns.nextSet = new RomanNumberSet("X","L");

            RomanNumberSet curr = rns;

            for (int i = 0; i <= 10; i++)
                Console.WriteLine(i + ": " + curr.ToNumber(i));

        }

        [TestMethod]
        public void TestShowRomanNumber()
        {
            Class3 c3 = new Class3();

            for(int i = 0; i < 3999; i++)
                Console.WriteLine(i + ": " + c3.ShowRomanNumber(i));
        }
    }
}
