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
                // break;
                // continue;
                // these two go out of the method and continue the program 

                //return;
                // jump out of the method

                // goto "label";
                // "label"
                // These keyword jump where the label is placed

                goto hello;

                Console.WriteLine("For each int: " + n.ToString());

                hello:
                Console.WriteLine("I jump the console");
            }

            // With strings
            string[] array2 = { "Hello", "World" };

            foreach (string s in array2)
            {
                Console.WriteLine("For each string: " + s);
            }
        }

        public void BuclesForLoop()
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

        public void WhileBucle()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            while (x < 6)
            {
                Console.WriteLine("While int " + array1[x].ToString());
                x++;
            }

            string[] array2 = { "Hello", "World" };
            int y = 0;

            while (y < 2)
            {
                Console.WriteLine("While string " + array2[y]);
                y++;
            }
        }

        public void BucleDoWhile()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            do
            {
                Console.WriteLine("Do while int " + array1[x].ToString());
                x++;
            } while (x < 6);

            string[] array2 = { "Hello", "World" };
            int y = 0;

            do
            {
                Console.WriteLine("Do while string " + array2[y]);
                y++;
            } while (y < 2);
        }
    }
}
