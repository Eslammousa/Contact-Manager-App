using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Contact__Manager_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ============== Welcome To Contact Manager ==============  ");
            List<Email> emails = new List<Email>();
            List<Phone> phones = new List<Phone>();
            List<Address> addresses = new List<Address>();
            List<User> users = new List<User>();



            var contact = new Contact();

            while (true)
            {

                Console.WriteLine(" 1- Add \n 2- Edit \n 3- Delete \n 4- Search \n 5- Display \n 6- Exit ");

                Console.Write("Enter number for operation : ");
                var number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    contact.Add(users);

                    Console.Write("Do you want to continue (y/n) : ");
                    var y = Console.ReadLine();

                    if (y != "y")
                    {
                        break;
                    }
                    else continue;

                }
                else if (number == 2)
                {
                    contact.Edit(users);

                    Console.Write("Do you want to continue (y/n) : ");
                    var y = Console.ReadLine();

                    if (y != "y")
                    {
                        break;
                    }
                    else continue;
                }
                else if (number == 3)
                {
                    contact.Delete(users);

                    Console.Write("Do you want to continue (y/n) : ");
                    var y = Console.ReadLine();

                    if (y != "y")
                    {
                        break;
                    }
                    else continue;
                }
                else if (number == 4)
                {
                    contact.Search(users);

                    Console.Write("Do you want to continue (y/n) : ");
                    var y = Console.ReadLine();

                    if (y != "y")
                    {
                        break;
                    }
                    else continue;
                }
                else if (number == 5)
                {
                    contact.Display(users);

                    Console.Write("Do you want to continue (y/n) : ");
                    var y = Console.ReadLine();

                    if (y != "y")
                    {
                        break;
                    }
                    else continue;
                }
                else if (number == 6)
                {
                    break;
                }

            }



        }




    }


}

