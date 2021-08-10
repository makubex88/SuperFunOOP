using System;
using System.Collections.Generic;
using System.Text;

namespace FunOOP.Models
{
    public class DBContext
    {
        public DBContext()
        {
            RunSeed();
        }
        public string DBConnStr { get; set; }

        public List<Agent> Agents { get; set; }

        private void RunSeed()
        {
            Agents = new List<Agent>
            {
                new Agent
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe"
                },

                new Agent
                {
                    Id = 2,
                    FirstName = "Alice",
                    LastName = "Doe"
                },

                new Agent
                {
                    Id = 3,
                    FirstName = "Bob",
                    LastName = "Doe"
                }
            };
        }

        public void SaveChanges()
        {
            //add database logic here
        }
    }
}
