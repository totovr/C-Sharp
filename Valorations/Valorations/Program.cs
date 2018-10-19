using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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
            SpeechSynthesizer talk = new SpeechSynthesizer();

            // Assignate values
            book.AddValoration(5);
            book.AddValoration(4);
            book.AddValoration(3);
            book.AddValoration(2);
            book.AddValoration(1);

            talk.Speak("This is the average of the evaluations");
            // Show the evaluations
            CalculateValorations publish = book.ShowEvaluations();
            Console.WriteLine("The average of the value is: " + publish.averageValue);
            Console.WriteLine("The min value is: " + publish.valueMin);
            Console.WriteLine("The max value is: " + publish.valueMax);
            Console.Beep();
            Console.ReadLine();
            // Min evaluation
            // Max evaluation
            // Average
        }
    }
}
