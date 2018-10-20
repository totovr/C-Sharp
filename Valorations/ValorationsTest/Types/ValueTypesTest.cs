using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valorations;


namespace ValorationsTest.Types
{
    [TestClass]
    public class ValueTypesTest
    {
        /*
        int x;
        float y;
        double z;
        string chain;
        */

        [TestMethod]
        public void ValueTypesTests()
        {
            int x1 = 10;
            int x2 = x1;
            // x1 = 20;
            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void EnumTypesValueTest()
        {
            BookValue book = new BookValue();
            book.Language = LanguageBook.EN;

            Assert.AreEqual(book.Language, LanguageBook.EN);
        }
    }
}
