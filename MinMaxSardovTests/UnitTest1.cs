using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MinMaxSardov;
using MinMaxSardovTests;

namespace MinMaxSardovTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            int expected = 4;

            ClassCompletion result = new ClassCompletion();
            int actual = result.ResTest(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
