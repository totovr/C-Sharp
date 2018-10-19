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

            // Assignate values
            book.AddValoration(5);
            book.AddValoration(5);

            // Show the evaluations
            CalculateValorations publish = book.ShowEvaluations();
            Console.WriteLine(publish.averageValue);
            Console.WriteLine();
            // Min evaluation
            // Max evaluation
            // Average
        }
    }
}
