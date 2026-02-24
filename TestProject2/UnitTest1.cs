using task2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject2.Tests
{
    [TestClass()]
    public class Tests
    {

        [TestMethod()]
        public void NumberZero()
        {
            string answer = Logic.FindFirstGreaterThanN(0);
            Assert.AreEqual("", answer);
        }
        [TestMethod()]
        public void SquareNumbe()
        {
            string answer = Logic.FindFirstGreaterThanN(4);
            Assert.AreEqual("1 4 4", answer);
        }
        [TestMethod()]
        public void NoSquareNumbe()
        {
            string answer = Logic.FindFirstGreaterThanN(5);
            Assert.AreEqual("1 4 5", answer);
        }
    }
}
