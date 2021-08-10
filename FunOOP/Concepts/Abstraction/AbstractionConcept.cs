using FunOOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunOOP.Concepts.Abstraction
{
    public class AbstractionConcept
    {
        public bool VerifyCustomerAddress(string address)
        {
            //call API
            var verified = CallWebAPIAddressVerification(address);

            return verified;
        }

        private bool CallWebAPIAddressVerification(string address)
        {
            //hiding irrelevant data like token, api endpoint, etc.

            //checking address
            Console.WriteLine($"Checking address: {address}");
            //do API Configs here.
            Console.WriteLine("Calling 3rd Party API");

            return true;
        }
    }


}
