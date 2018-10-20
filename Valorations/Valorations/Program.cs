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
            book.Language = LanguageBook.EN;
            // SpeechSynthesizer talk = new SpeechSynthesizer();
            _3DVector myVector;
            myVector.x = 10;
            myVector.y = 10;
            myVector.z = 30.30f;

            // Assignate values
            book.AddValoration(5);
            book.AddValoration(4);
            book.AddValoration(3);
            book.AddValoration(2);
            book.AddValoration(1);

            // talk.Speak("This is the average of the evaluations");
            // This is the same as:
            // CalculateValorations publish = new CalculateValoration();
            // publish = book.ShowEvaluations();
            CalculateValorations publish = book.ShowEvaluations();
            Console.WriteLine("The average of the value is: " + publish.AverageValue);
            Console.WriteLine("The min value is: " + publish.ValueMin);
            Console.WriteLine("The max value is: " + publish.ValueMax);
            // Console.Beep();
            Console.ReadLine();
            // Min evaluation
            // Max evaluation
            // Average
        }
    }
}
