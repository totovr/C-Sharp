using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations.ControlStructures
{
    class Bucles
    {
        // Function: Go over collection of data (Array, ArrayList, Lists, Dictionaries)

        public void BuclesForEach()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            
            // With numerics 
            foreach (int n in array1)
            {
                Console.WriteLine("For each string: " + n.ToString());
            }

            // With strings
            string[] array2 = { "Hello", "World" };

            foreach(string s in array2)
            {
                Console.WriteLine("For each string: " + s);
            }
        }

        public void BuclesForLopp()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };

            // With numerics 
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("For loop int: " + array1[i].ToString());
            }

            // With strings
            string[] array2 = { "Hello", "World" };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("For each string: " + array2[i]);
            }

        }
    }
}
