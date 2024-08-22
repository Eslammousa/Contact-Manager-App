using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Contact__Manager_Application
{
    internal class User 
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string AddDate { get; set; }

        public void Add(List<Email> emails, List<Phone> phones, List<Address> addresses)
        {
            Console.WriteLine(" ============= Adding your Email ============== ");
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();
            var email1 = new Email
            {
                SetEmail = email,
                SetType  = type,
                SetDescription = description
            }; emails.Add(email1);

            Console.WriteLine(" ============= Adding your Phone ============== ");
            Console.Write("Enter Phone : ");
            string phone_ = Console.ReadLine();
            Console.Write("Enter Type : ");
            var type_ = Console.ReadLine();
            Console.Write("Enter Description : ");
            var description_ = Console.ReadLine();
            var phonee = new Phone
            {
                SetPhone = phone_,
                SetType = type_,
                SetDescription = description_

            };phones.Add(phonee);

            Console.WriteLine(" ============= Adding your Address ============== ");
            Console.Write("Enter Place : ");
            string place = Console.ReadLine();
            Console.Write("Enter Type : ");
            string _type = Console.ReadLine();
            Console.Write("Enter Description : ");
            string _description = Console.ReadLine();

             var addresss = new Address
            {
              SetPlace = place,
                SetType = _type,
                SetDescription = _description
            };
            addresses.Add(addresss);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your Info has been added successfully ");

        }

        public void IsFound(List<Email> emails, List<Phone> phones, List<Address> addresses)
        {
            Console.WriteLine("======================= searching your Info ========================= ");

            Console.WriteLine(" 1- Email \n 2- Phone \n 3- Address");

            Console.Write("Enter number for Search : ");

            var number = int.Parse(Console.ReadLine());
            if (number > 3 || number <= 0)
            {
                Console.WriteLine("Invalid Number you can try again ");
                Environment.Exit(0);
            }
   
                if (number == 1)
                {
                    Console.Write("select Email : ");
                    var search = Console.ReadLine();
                    if (emails.Any(x => x.SetEmail == search)) Console.WriteLine("Successfully Found your Email !");
                    else if (emails.Any(x => x.SetType == search)) Console.WriteLine("Successfully Found your Email !");
                    else if (emails.Any(x => x.SetDescription == search)) Console.WriteLine("Successfully Found your Email !");
                    else Console.WriteLine("Failed to Found your Email !");
                }

                else if (number == 2)
                {
                    Console.Write("select Phone : ");
                    var search = Console.ReadLine();
                    if (phones.Any(x => x.SetPhone == search)) Console.WriteLine("Successfully Found your Phone !");
                    else if(phones.Any(x => x.SetType == search)) Console.WriteLine("Successfully Found your Phone !");
                    else if(phones.Any(x => x.SetDescription == search)) Console.WriteLine("Successfully Found your Phone !");
                    else Console.WriteLine("Failed to Found your Phone !");
            }

                else if (number == 3)
                {
                    Console.Write("select Address : ");
                    var search = Console.ReadLine();
                    if (addresses.Any(x => x.SetPlace == search)) Console.WriteLine("Successfully Found your Address !");
                    else if (addresses.Any(x => x.SetType == search)) Console.WriteLine("Successfully Found your Address !");
                    else if (addresses.Any(x => x.SetDescription == search)) Console.WriteLine("Successfully Found your Address !");
                    else Console.WriteLine("Failed to Found your Address !");
            }

        }

        public void Edit(List<Email> emails, List<Phone> phones, List<Address> addresses)
        {

            Console.WriteLine("=============== Edit your Info ===================");

            Console.WriteLine(" 1- Email \n 2- Phone \n 3- Address");

            Console.Write("Enter number for Edit : ");

            var number = int.Parse(Console.ReadLine());
            if (number > 3 || number <= 0)
            {
                Console.WriteLine("Invalid Number you can try again ");
                Environment.Exit(0);
            }

                if (number == 1)
                {
                    Console.WriteLine("=============== Edit your Email =============== ");
                    Console.Write("old Email : ");
                    var old = Console.ReadLine();
                    Console.Write("new Email : ");
                    var New = Console.ReadLine();
                    var new_email = new Email
                    {
                        SetEmail = New
                    };
                    var index = emails.FindIndex(x => x.SetEmail == old);
                    emails[index] = new_email;
                Console.WriteLine($" Email has been changed successfully ");

            }

                if (number == 2)
                {
                    Console.WriteLine("=============== Edit your Phone =============== ");
                    Console.Write("old Phone : ");
                    var old = Console.ReadLine();
                    Console.Write("New Phone : ");
                    var New = Console.ReadLine();

                    var new_phone = new Phone
                    {
                        SetPhone = New
                    };

                    var index = phones.FindIndex(x => x.SetPhone == old);
                    phones[index] = new_phone;
                Console.WriteLine($" Phone number has been changed successfully ");

                }

                if (number == 3)
                {
                    Console.WriteLine("=============== Edit your Address ===============  ");
                    Console.Write("old Address : ");
                    var old = Console.ReadLine();
                    Console.Write("New Address : ");
                    var New = Console.ReadLine();

                    var new_Address = new Address
                    {
                        SetPlace = New
                    };
                    var index = addresses.FindIndex(x => x.SetPlace == old);
                   addresses[index] = new_Address;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" Address has been changed successfully ");

            }
            }

        public void Delete(List<Email> emails, List<Phone> phones, List<Address> addresses)
        {
            Console.WriteLine("=============== Delete your Info  =============== ");

            Console.WriteLine(" 1- Email \n 2- Phone \n 3- Address");

            Console.Write("Enter number for Delete : ");

            var number = int.Parse(Console.ReadLine());

            if (number > 3 || number <= 0)
            {
                Console.WriteLine("Invalid Number you can try again ");
                Environment.Exit(0);
            }
            Console.ForegroundColor = ConsoleColor.Green;

            if (number == 1)
                {
                    Console.WriteLine(" =============== Delete your Email =============== ");
                    Console.Write("Enter Email : ");
                    var delete = Console.ReadLine();

                    var index = emails.FindIndex(x => x.SetEmail == delete || x.SetType == delete || x.SetDescription == delete);
                    emails.RemoveAt(index);
                    Console.WriteLine("Email has been deleted successfully !");
                }

                if (number == 2)
                {
                    Console.WriteLine(" ===============Delete your Phone =============== ");
                    Console.Write("Enter Phone : ");
                    var delete = Console.ReadLine();

                    var index = phones.FindIndex(x => x.SetPhone == delete || x.SetType == delete || x.SetDescription == delete);
                    phones.RemoveAt(index);
                Console.WriteLine("Phone has been deleted successfully !");
            }

                if (number == 3)
                {
                    Console.WriteLine("=============== Delete your Address =============== ");
                    Console.Write("Enter Address : ");
                    var delete = Console.ReadLine();

                    var index = addresses.FindIndex(x => x.SetPlace == delete || x.SetType == delete || x.SetDescription == delete);
                    addresses.RemoveAt(index);
                    Console.WriteLine("Address has been deleted successfully !");
            }

            }

        public void DisplayUser(List<Email> emails, List<Phone> phones, List<Address> addresses)
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"FirstName : {FirstName}");
            Console.WriteLine($"LastName : {LastName}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"City : {City}");
            Console.WriteLine($"AddDate : {AddDate}");

            Console.WriteLine("Emails : ");
            foreach (var email in emails)
            {
                email.GetEmail();
            }
            Console.WriteLine("Phones : ");
            foreach (var phone in phones)
            {
                phone.GetPhone();
            }
            Console.WriteLine("Addresses : ");
            foreach (var address in addresses)
            {
                address.GetAddress();
            }



        }

        }



 }

    