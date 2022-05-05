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
    public class usingfloatTests
    {
        [TestMethod()]
        public void MaximumfloatTest()
        {
            usingfloat Usingfloat = new usingfloat();
            double result = Usingfloat.Maximumfloat(6.6, 5.5, 4.4);
            Assert.AreEqual(6.6, result);

        }
        [TestMethod()]
        public void MaximumfloatTest2()
        {
            usingfloat Usingfloat1 = new usingfloat();
            double result1 = Usingfloat1.Maximumfloat(3.3, 7.7, 6.6);
            Assert.AreEqual(7.7, result1);
        }
        [TestMethod()]
        public void MaximumfloatTest3()
        {
            usingfloat Usingfloat2 = new usingfloat();
            double result2 = Usingfloat2.Maximumfloat(3.3, 7.7, 8.8);
            Assert.AreEqual(8.8, result2);
        }
    }
}