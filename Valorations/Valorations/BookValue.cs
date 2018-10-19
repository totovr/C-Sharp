using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorations
{
    class BookValue
    {
        // static means that never will change
        public static string name = "Tono";
        public List<float> valorations;
        // ctor
        // This is the method that automatically is created by the system, but we also write it to modify it 
        public BookValue()
        {
            valorations = new List<float>();
        }

        // Return a data of the same type
        public CalculateValorations ShowEvaluations()
        {
            CalculateValorations calculus = new CalculateValorations();
            float plusValues = 0;
            foreach (float valoration in valorations)
            {
                plusValues += valoration;
            }
            // Quantity of values that are in the list
            calculus.averageValue = plusValues / valorations.Count;
            return calculus; 
        }

        public void AddValoration(float valoration)
        {
            valorations.Add(valoration);
        }
       
    }
}
