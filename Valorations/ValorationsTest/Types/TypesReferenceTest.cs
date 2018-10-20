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
    public class TypesReferenceTest
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

        [TestMethod]
        public void MyArrayTestMethod()
        {
            // How many objects will store
            letters = new string[3];
            AddLetter("A");
            Assert.AreEqual("A", letters[0]);

        }

        [TestMethod]
        public void IntTestMethod()
        {
            numbersReference = new int[3];
            numbersReference[0] = 1;
            numbersReference[0] = 2;
            numbersReference[0] = 3;
            // Not necessary to construct the object "new" because the object was already referenced
            int[] numbersReference2 = numbersReference;
            Assert.AreEqual(numbersReference[0], numbersReference2[0]);
        }

        void AddLetter(string L)
        {
            letters[0] = L;
        }

        string[] letters;
        int[] numbersReference;

    }
}
