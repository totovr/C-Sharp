using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ValorationsTest.Types
{
    [TestClass]
    public class ValueTypes
    {
        /*
        int x;
        float y;
        double z;
        string chain;
        */

        [TestMethod]
        public void ValueTypesTest()
        {
            int x1 = 10;
            int x2 = x1;
            // x1 = 20;
            Assert.AreEqual(x1, x2);
        }
    }
}
