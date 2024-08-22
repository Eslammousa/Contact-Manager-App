using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact__Manager_Application
{
    internal class Email
    {
        private string email;
        private string type;
        private string description;

       public string SetEmail { get; set; }
       public string SetType { get; set; }
       public string SetDescription { get; set; }

       public void GetEmail()
       {
           Console.WriteLine($"Email: {SetEmail}");
           Console.WriteLine($"Type: {SetType}");
           Console.WriteLine($"Description: {SetDescription}");
       }

     


    }
}
