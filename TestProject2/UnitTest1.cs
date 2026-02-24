using NUnit.Framework;
using task2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Tests
{
    [TestClass()]
    public class Tests
    {

        [TestMethod()]
        public void Test1()
        {

            int n = 0;
            string answer = Logic.FindFirstGreaterThanN(n);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1 0", answer);
        }





        [TestMethod()]
        public void Test2()
        {

            int n = 4;
            string answer = Logic.FindFirstGreaterThanN(n);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1 4 4", answer);
        }




        [TestMethod()]
        public void Test3()
        {

            int n = 5;
            string answer = Logic.FindFirstGreaterThanN(n);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1 4 9 5", answer);
        }
    }
}
