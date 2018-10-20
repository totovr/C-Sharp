using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valorations;

namespace ValorationsTest
{
    [TestClass]
    public class InmutableTest
    {
        [TestMethod]
        public void InmutableTestMethod()
        {
            string name = "Tono";
            name = name.ToUpper();

            Assert.AreEqual("TONO", name);

            BookValue book1 = new BookValue();
            book1.Name = "Tono";
            book1.Name = book1.Name.ToUpper();

            Assert.AreEqual("TONO", book1.Name);

            DateTime date = new DateTime(1992, 2, 22);
            date = date.AddDays(1);
            Assert.AreEqual(23, date.Day);

        }

    }
}
