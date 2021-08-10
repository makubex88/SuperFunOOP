using FunOOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunOOP.Concepts.Encapsulation
{
    public class EncapulationConcept : Agent
    {
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                return ComputeAge();
            }
        }

        //ensure we are getting the correct data.
        private int ComputeAge()
        {
            return Convert.ToInt32((DateTime.Now - BirthDate).TotalDays);
        }


        ///////////////
        /// <summary>
        /// 
        /// </summary>
        public void GetValues()
        {
            this.Id = 5;
            this.LastName = "Mouse";
            this.FirstName = "Mickey";
        }

        public void DisplayCurrentAgent()
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"First Name:{FirstName}");
            Console.WriteLine($"Last Name:{LastName}");
            Console.WriteLine($"Birth Date:{BirthDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Age:{Age.ToString()}");
        }
    }
}
    