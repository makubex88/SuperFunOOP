using System;
using System.Collections.Generic;
using System.Text;

namespace FunOOP.Concepts.Polymorphism
{
    /// <summary>
    /// Overriding
    /// </summary>
    public class APACADataSet
    {
        public virtual void AddCustomer()
        {
            Console.WriteLine("Data Added to APACA");
        }
    }

    public class APACAOneDataSet : APACADataSet
    {
        //same method but
        //different implementation
        public override void AddCustomer()
        {
            //with validation codes here...

            Console.WriteLine("Data Added to APACAOne - WebService");
            
        }
    }
    
    /// <summary>
    /// Overloading
    /// </summary>
    public class AgentPerfomance 
    {
        public void Compute()
        {
            Console.WriteLine("Ordinary Compute");
        }

        public void Compute(string addOn)
        {
            Console.WriteLine("With AddOn Matrix Compute");
        }
    }

}
