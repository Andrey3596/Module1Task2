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
        public void Test()
        {

            int n = 0;
            string answer = Logic.FindFirstGreaterThanN(n);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1 0", answer);
        }
    }
}
