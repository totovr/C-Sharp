using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations.ControlStructures
{
    class SwitchCase
    {
        public void SwitchCaseExample1()
        {
            int caseSwitch = 2;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public void SwitchCaseExample2()
        {
            int caseSwitch = 3;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                // Is possible to jump number of cases
                case 7 - 4:
                    Console.WriteLine("Default case");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public void SwitchCaseExample3()
        {
            Console.WriteLine("Chose a size of glass");
            Console.WriteLine("Size of glass: 1 = small, 2 = medium, 3 = big");
            Console.Write("Choose one: ");
            string str = Console.ReadLine();
            int cost = 0;
            switch(str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 25;
                    goto case "1";
                case "3":
                case "big":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("The selection was not valid, type 1, 2 or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("The total is {0} ponds", cost);
            }
            Console.WriteLine("Thanks for your buying");
        }
    }
}
