using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Contact__Manager_Application
{
    internal class Contact
    {
        public void GreenColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void WhiteColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void RedColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Add(List<User> users)
        {
            Console.WriteLine(" ============= Adding info about User ============== ");

            Console.Write("Add First Name : ");
            var firstName = Console.ReadLine();

            Console.Write("Add Last Name : ");
            var lastName = Console.ReadLine();

            Console.Write("Add your Gender : ");
            var gender = Console.ReadLine();

            Console.Write("Add your City : ");
            var city = Console.ReadLine();

            Console.Write("Add your Date : ");
            var date = Console.ReadLine();

            var newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                City = city,
                AddDate = date,
            }; users.Add(newUser);
            GreenColor();
            Console.WriteLine("Your Info has been added successfully ");
            WhiteColor();
        }

        public void Edit(List<User> users)
        {
            Console.WriteLine("=============== Edit your Info ===================");

            Console.WriteLine(" 1- First Name \n 2- Last Name \n 3- Gender \n 4- City \n 5- Date ");

            Console.Write("Enter number for Edit : ");
            var number = int.Parse(Console.ReadLine());

            if (number > 5 || number <= 0)
            {
                RedColor();
                Console.WriteLine("Invalid Number you can try again");
                Environment.Exit(0);
            }
            if(number == 1)
            {
                Console.WriteLine("=============== Edit your First Name ===============");
                Console.Write("old First Name : ");
                var old = Console.ReadLine();
                Console.Write("new First Name : ");
                var New = Console.ReadLine();
                var index = users.FindIndex(x => x.FirstName == old);
                users[index].FirstName = New;
                GreenColor();
                Console.WriteLine($"First Name has been changed successfully -> { New } ");
                WhiteColor();
            }

            if(number == 2)
            {
                Console.WriteLine("=============== Edit your Last Name ===============");
                Console.Write("old Last Name : ");
                var old = Console.ReadLine();
                Console.Write("new Last Name : ");
                var New = Console.ReadLine();
                var index = users.FindIndex(x => x.LastName == old);
                users[index].LastName = New;
                GreenColor();
                Console.WriteLine($"Last Name has been changed successfully -> { New } ");
                WhiteColor();
            }


            if(number == 3)
            {
                Console.WriteLine("=============== Edit your Gender ===============");
                Console.Write("old Gender : ");
                var old = Console.ReadLine();
                Console.Write("new Gender : ");
                var New = Console.ReadLine();
                var index = users.FindIndex(x => x.Gender == old);
                users[index].Gender = New;
                GreenColor();
                Console.WriteLine($"Gender has been changed successfully -> { New } ");
                WhiteColor();
            }


            if(number == 4)
            {
                Console.WriteLine("=============== Edit your City ===============");
                Console.Write("old City : ");
                var old = Console.ReadLine();
                Console.Write("new City : ");
                var New = Console.ReadLine();
                var index = users.FindIndex(x => x.City == old);
                users[index].City = New;
                GreenColor();
                Console.WriteLine($"City has been changed successfully -> { New } ");
                WhiteColor();
            }

            if(number == 5)
            {
                Console.WriteLine("=============== Edit your Date ===============");
                Console.Write("old Date : ");
                var old = Console.ReadLine();
                Console.Write("new Date : ");
                var New = Console.ReadLine();
                var index = users.FindIndex(x => x.AddDate == old);
                users[index].AddDate = New;
                GreenColor();
                Console.WriteLine($"Date has been changed successfully -> { New } ");
                WhiteColor();
            }
          

        }


        public void Delete(List<User> users)
        {
            Console.WriteLine("=============== Delete your Info  =============== ");
            Console.WriteLine(" 1- First Name \n 2- Last Name \n 3- Gender \n 4- City \n 5- Date ");
            Console.Write("Enter number for Delete : ");
            var number = int.Parse(Console.ReadLine());

            if (number > 5 || number <= 0)
            {
                RedColor();
                Console.WriteLine("Invalid Number you can try again");
                Environment.Exit(0);
            }

            if (number == 1)
            {
                Console.WriteLine(" =============== Delete your First Name =============== ");
                Console.Write("Enter First Name : ");
                var delete = Console.ReadLine();
                var index = users.FindIndex(x => x.FirstName == delete);
                users.RemoveAt(index);
                GreenColor();
                Console.WriteLine("First Name has been deleted successfully !");
                WhiteColor();
            }
            if (number == 2)
            {
                Console.WriteLine(" =============== Delete your Last Name =============== ");
                Console.Write("Enter Last Name : ");
                var delete = Console.ReadLine();
                var index = users.FindIndex(x => x.LastName == delete);
                users.RemoveAt(index);
                GreenColor();
                Console.WriteLine("Last Name has been deleted successfully !");
                WhiteColor();
            }
            if (number == 3)
            {
                Console.WriteLine(" =============== Delete your Gender =============== ");
                Console.Write("Enter Gender : ");
                var delete = Console.ReadLine();
                var index = users.FindIndex(x => x.Gender == delete);
                users.RemoveAt(index);
                GreenColor();
                Console.WriteLine("Gender has been deleted successfully !");
                WhiteColor();
            }
            if (number == 4)
            {
                Console.WriteLine(" =============== Delete your City =============== ");
                Console.Write("Enter City : ");
                var delete = Console.ReadLine();
                var index = users.FindIndex(x => x.City == delete);
                users.RemoveAt(index);
                GreenColor();
                Console.WriteLine("City has been deleted successfully !");
                WhiteColor();
            }
            if (number == 5)
            {
                Console.WriteLine(" =============== Delete your Date =============== ");
                Console.Write("Enter Date : ");
                var delete = Console.ReadLine();
                var index = users.FindIndex(x => x.AddDate == delete);
                users.RemoveAt(index);
                GreenColor();
                Console.WriteLine("Date has been deleted successfully !");
                WhiteColor();
            }


        }

        public void Search(List<User> users)
        {
            Console.WriteLine("=============== Search your Info  =============== ");
            Console.WriteLine(" 1- First Name \n 2- Last Name \n 3- Gender \n 4- City \n 5- Date ");
            Console.Write("Enter number for Search : ");
            var number = int.Parse(Console.ReadLine());
             if (number > 5 || number <= 0)
            {
                RedColor();
                Console.WriteLine("Invalid Number you can try again");
                Environment.Exit(0);
            }

             if(number == 1)
            {
                Console.WriteLine("============= Search your First Name ===============");
                Console.Write("Enter First Name : ");
                var search = Console.ReadLine();
                if (users.Any(x => x.FirstName == search))
                {   
                     GreenColor();
                    Console.WriteLine($"Successfully Found your First Name ! --> {search}");
                    WhiteColor();
                }
                else
                {
                    RedColor();
                    Console.WriteLine("Failed to Found your First Name !");
                }


            }
            if (number == 2)
            {
                Console.WriteLine("============= Search your Last Name ===============");
                Console.Write("Enter Last Name : ");
                var search = Console.ReadLine();
                if (users.Any(x => x.LastName == search))
                {
                    GreenColor();
                    Console.WriteLine($"Successfully Found your Last Name ! --> {search}");
                    WhiteColor();
                }
                else
                {
                    RedColor();
                    Console.WriteLine("Failed to Found your Last Name !");
                }
            }


            if(number == 3)
            {
                Console.WriteLine("============= Search your Gender ===============");
                Console.Write("Enter Gender : ");
                var search = Console.ReadLine();
                if (users.Any(x => x.Gender == search))
                {
                    GreenColor();
                    Console.WriteLine($"Successfully Found your Gender ! --> {search}");
                    WhiteColor();
                }
                else
                {
                    RedColor();
                    Console.WriteLine("Failed to Found your Gender !");
                }
            }


            if(number == 4)
            {
                Console.WriteLine("============= Search your City ===============");
                Console.Write("Enter City : ");
                var search = Console.ReadLine();
                if (users.Any(x => x.City == search))
                {
                    GreenColor();
                    Console.WriteLine($"Successfully Found your City ! --> {search}");
                    WhiteColor();
                }
                else
                {
                    RedColor();
                    Console.WriteLine("Failed to Found your City !");
                }
            }

            if(number == 5)
            {
                Console.WriteLine("============= Search your Date ===============");
                Console.Write("Enter Date : ");
                var search = Console.ReadLine();
                if (users.Any(x => x.AddDate == search))
                {
                    GreenColor();
                    Console.WriteLine($"Successfully Found your Date ! --> {search}");
                    WhiteColor();
                }
                else
                {
                    RedColor();
                    Console.WriteLine("Failed to Found your Date !");
                }
            }











        }


       public void Display(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"1- First Name : {item.FirstName}\n2- Last Name : {item.LastName}\n 3- Gender : {item.Gender}\n 4- City : {item.City}\n 5- Date : {item.AddDate}");
            }


        }



    }
}
