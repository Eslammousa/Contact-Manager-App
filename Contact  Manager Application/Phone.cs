using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact__Manager_Application
{
    internal class Phone
    {
        public string SetPhone { get; set; }

        public string SetType { get; set; }

        public string SetDescription { get; set; }

        public void GetPhone()
        {
           Console.WriteLine($"Number of Phone: {SetPhone}");
           Console.WriteLine($"Type of Phone: {SetType}");
           Console.WriteLine($"Description of Phone: {SetDescription}");
        }




    }
}
