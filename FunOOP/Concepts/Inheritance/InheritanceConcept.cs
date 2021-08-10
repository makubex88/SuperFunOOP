using FunOOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunOOP.Concepts.Inheritance
{
    public class BaseDAL
    {
        public DBContext db;

        public BaseDAL(DBContext _db)
        {
            db = _db;
        }
        
        public void Save() 
        {
            db.SaveChanges();
        } 
    }

    public class AgentDAL : BaseDAL
    {
        //inherits base class of data access layers
        public AgentDAL(DBContext context) : base(context)
        {
            db = context;
        }

        public void Add(Agent model)
        {
            //add to ef
            db.Agents.Add(model);
        }

        public void DisplayAgents()
        {
            foreach(var a in db.Agents)
            {
                Console.WriteLine($"Id:{a.Id}");
                Console.WriteLine($"First Name:{a.FirstName}");
                Console.WriteLine($"Last Name:{a.LastName}");
            }
        }

        public List<string> ListOfHandleAgents { get; set; }
    }

    
}