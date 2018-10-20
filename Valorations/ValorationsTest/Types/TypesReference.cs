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
    public class TypesReference
    {
        [TestMethod]
        public void VariablesTypesReference()
        {
            BookValue l1 = new BookValue();
            l1.Name = "Tono Book";
            BookValue l2 = l1;
            l1.Name = "Book...";
            Assert.AreEqual(l1.Name, l2.Name);
        }
    }
}
