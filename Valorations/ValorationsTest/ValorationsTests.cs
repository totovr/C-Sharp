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
    public class ValorationsTests
    {
        // We write the method that we want to evaluate
        [TestMethod]
        public void averageValue()
        {
            BookValue book = new BookValue();
            book.AddValoration(5);
            book.AddValoration(4);
            book.AddValoration(3);
            book.AddValoration(2);
            book.AddValoration(1);

            CalculateValorations result = book.ShowEvaluations();
            // this must ve the same 
            Assert.AreEqual(3, result.AverageValue);
        }
    }
}
