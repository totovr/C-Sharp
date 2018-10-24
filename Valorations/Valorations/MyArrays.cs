using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    public class MyArrays
    {
        public void ArrayWorking()
        {
            string[] arrayString;
            arrayString = new string[3];

            // string[] arrayString = new string{A,B,C};

            arrayString[0] = "A";
            arrayString[1] = "B";
            arrayString[2] = "C";

            // It is already created above
            string[] arrayString2 = arrayString; 
            arrayString2[1] = "A";

            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            int[,] numbers2D = new int[3, 3] { { 9, 99, 9 }, { 3, 33, 3 }, { 4, 44, 4 } };
            foreach (int i in numbers2D)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            //Automatically detect the size of the array
            int[,] numbers2DResume = { { 9, 9 }, { 3, 3 }, { 4, 4 } };
            foreach (int i in numbers2DResume)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

    }
}
