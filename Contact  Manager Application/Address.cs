using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact__Manager_Application
{
    internal class Address
    {
      //  pub string SetAddress;

        public string SetPlace { get; set; }
        public string SetType { get; set; }
        public string SetDescription { get; set; }


        public void GetAddress()
        {
            Console.WriteLine($"Place: {SetPlace}");
            Console.WriteLine($"Type: {SetType}");
            Console.WriteLine($"Description: {SetDescription}");
        }
    }
}
