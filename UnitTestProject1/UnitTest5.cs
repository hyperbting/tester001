using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestUseAllClasses()
        {
            Class5 c5 = new Class5();
            Console.Write(c5.UseAllClasses(99,87));
        }
    }
}
