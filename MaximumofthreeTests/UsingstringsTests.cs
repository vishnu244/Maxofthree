using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maximumofthree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximumofthree.Tests
{
    [TestClass()]
    public class UsingstringsTests
    {
        [TestMethod()]
        public void MaximumstringTest()
        {
            Usingstrings usingstrings = new Usingstrings();
            string result = usingstrings.MaxValueStrings("Apple","Peach", "Banana");
            Assert.AreEqual("Banana", result);

        }
        [TestMethod()]
        public void MaximumstringTest2()
        {
            Usingstrings usingstrings1 = new Usingstrings();
            string result1 = usingstrings1.MaxValueStrings("Apple", "Peach", "Banana");
            Assert.AreEqual("Banana", result1);
        }
        [TestMethod()]
        public void MaximumstringTest3()
        {
            Usingstrings usingstrings2 = new Usingstrings();
            string result2 = usingstrings2.MaxValueStrings("Apple", "Peach", "Banana");
            Assert.AreEqual("Banana", result2);
        }
    }
}