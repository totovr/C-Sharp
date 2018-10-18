using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new constructor
            BookValue book = new BookValue();
            book.AddValoration(3.5f);
            book.AddValoration(5);
        }
    }
}
