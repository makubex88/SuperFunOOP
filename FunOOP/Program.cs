using FunOOP.Concepts.Abstraction;
using FunOOP.Concepts.Encapsulation;
using FunOOP.Concepts.Inheritance;
using FunOOP.Concepts.Polymorphism;
using FunOOP.Models;
using System;

namespace FunOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DBContext();

            //Abstraction
            var abs = new AbstractionConcept();
            var verified = abs.VerifyCustomerAddress("SM Technopark building sample place");
            Console.WriteLine($"Address is {(verified ? "verified" : "not verified")}");

            ////Encapsulation
            var agentOne = new EncapulationConcept(); 
            agentOne.GetValues();
            agentOne.BirthDate = DateTime.Now.AddDays(-37);
            agentOne.DisplayCurrentAgent();

            //Inheritance
            var agentDAL = new AgentDAL(db);
            agentDAL.Add(new Agent
            {
                Id = 4,
                FirstName = "Trister",
                LastName = "Vention"
            });
            agentDAL.Save();
            agentDAL.DisplayAgents();

            //Polymorphism

            //Compile Time
            var agentPerf = new AgentPerfomance();
            agentPerf.Compute();
            agentPerf.Compute("without absent");

            //Run time
            var apaca = new APACADataSet();
            var apacaOne = new APACAOneDataSet();
            apaca.AddCustomer();
            apacaOne.AddCustomer();

            Console.ReadLine();
        }
    }
}
