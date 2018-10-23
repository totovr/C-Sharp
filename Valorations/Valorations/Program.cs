using System;
using System.Collections.Generic;
using System.Linq;
// using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create constructors
            BookValue book = new BookValue();
            // SpeechSynthesizer talk = new SpeechSynthesizer();
            _3DVector myVector;
            MyArrays myArray = new MyArrays();

            // Methods
            myArray.ArrayWorking();

            // Assignate propierties
            myVector.x = 10;
            myVector.y = 10;
            myVector.z = 30.30f;
            book.Language = LanguageBook.EN;
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
            // Because of inmutability we have to store the value of the object in one variable
            float maxValoration = publish.ValueMax;
            float minValoration = publish.ValueMin;
            float averageValoration = publish.AverageValue;

            WriteValorations("The average of the value is: ", averageValoration);
            WriteValorations("The min value is: ", minValoration);
            WriteValorations("The max value is: ", maxValoration);
            // Console.Beep();
            Console.ReadLine();
        }

        private static void WriteValorations(string description, float valoration)
        {
            Console.WriteLine("{0}"+"{1}", description, valoration);
        }
    }
}
