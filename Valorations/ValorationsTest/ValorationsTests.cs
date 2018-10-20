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
        [TestMethod]
        public void CalculateMaxValue()
        {
            BookValue book = new BookValue();
            book.AddValoration(5);

            CalculateValorations result = book.ShowEvaluations();

            Assert.AreEqual(5, result.valueMax);
        }
    }
}
