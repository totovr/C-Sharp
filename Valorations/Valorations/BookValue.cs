using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    // enum will not change
    public enum LanguageBook
    {
        none, EN, ES, GE, IT
    }

    // internal is a work that make just able to access internally to this work space the class
    // internal class BookValue
    public class BookValue
    {

        private string _lettersValoration;
        public string lettersValoration
        {
            get
            {
                return _lettersValoration;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // if is diffeerente of null it will send the _name value
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public LanguageBook Language;
        private List<float> valorations;

        public BookValue()
        {
            // Initialize list
            valorations = new List<float>();
        }

        // Return a data of the same type
        public CalculateValorations ShowEvaluations()
        {
            CalculateValorations calculus = new CalculateValorations();
            float plusValues = 0;
            foreach (float valoration in valorations)
            {
                // Math is a method of the system 
                calculus.ValueMin = Math.Min(valoration, calculus.ValueMin);
                calculus.ValueMax = Math.Max(valoration, calculus.ValueMax);
                plusValues += valoration;
            }
            // Quantity of values that are in the list
            calculus.AverageValue = plusValues / valorations.Count;
            AssignLetterValoration(calculus.AverageValue);
            return calculus; 
        }

        private void AssignLetterValoration(float AV)
        {
            if (AV <= 5 && AV > 4)
            {
                _lettersValoration = "A";
            }
            else if (AV <= 4 && AV > 3)
            {
                _lettersValoration = "B";
            }
            else if (AV <= 3 && AV > 2)
            {
                _lettersValoration = "C";
            }
            else if (AV <= 2 && AV > 1)
            {
                _lettersValoration = "C";
            }
            else 
            {
                _lettersValoration = "D";
            }
        }

        public void AddValoration(float valoration)
        {
            // This is a list
            valorations.Add(valoration);
        }
       
    }
}
