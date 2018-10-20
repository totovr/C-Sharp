using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    // internal is a work that make just able to access internally to this work space the class
    // internal class BookValue
    public class BookValue
    {
        // static means that never will change
        // public static string name = "Tono";
        // ctor
        // This is the method that automatically is created by the system, but we also write it to modify it 
        public string Name;
        List<float> valorations;

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
            return calculus; 
        }

        public void AddValoration(float valoration)
        {
            // This is a list
            valorations.Add(valoration);
        }
       
    }
}
