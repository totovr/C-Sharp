using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    class BookValue
    {
        List<float> valorations;

        public BookValue()
        {
            valorations = new List<float>();
        }
            
        public void AddValoration(float valoration)
        {
            valorations.Add(valoration);
        }
       
    }
}
