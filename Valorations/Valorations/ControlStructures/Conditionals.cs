using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations.ControlStructures
{
    public class Conditionals
    {
        int num = 10;
        int num2 = 20;

        public void BasicConditional()
        {
            if (num == num2)
            {
                Console.WriteLine("This numbers are equal");
            }
        }

        public void BasicConditional2()
        {
            if (num == num2)
            {
                Console.WriteLine("This numbers are equal");
            }
            else
            {
                Console.WriteLine("This numbers are not equal");
            }
        }

        public void NestedConditional()
        {
            if (num == num2)
            {
                Console.WriteLine("This numbers are equal");
            }
            else if (num >= num2)
            {
                Console.WriteLine(num + "Is greater than " + num2);
            }
            else
            {
                Console.Write(num + "Is smaller than " + num2);
            } 
        }

        // This is not a good written code
        public void ConditionalNotRecomendded()
        {
            if (num == num2 && num > num2)
            {
                Console.WriteLine("This numbers are equal");
                if (num == num2)
                {
                    Console.WriteLine("This numbers are equal");
                }
                else if (num >= num2)
                {
                    Console.WriteLine(num + "Is greater than " + num2);
                }
                else
                {
                    Console.Write(num + "Is smaller than " + num2);
                }
            }
            else if (num >= num2)
            {
                Console.WriteLine(num + "Is greater than " + num2);
            }
            else
            {
                Console.Write(num + "Is smaller than " + num2);
            }

        }

        public void ProbesReturn()
        {
            int result1 = ShowProbeValue(0);
            int result2 = ShowProbeValue(50);
            int result3 = ShowProbeValue(-1);

            // To show it is necessary to summon it directly in the Main
            Console.WriteLine("The value is: " + result1);
            Console.WriteLine("The value is: " + result2);
            Console.WriteLine("The value is: " + result3);
        }

        public int ShowProbeValue(int value)
        {
            if (value == 0)
            {
                return -1;
            }
            else if (value <= 10)
            {
                return 0;
            }
            else if (value <= 100)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
