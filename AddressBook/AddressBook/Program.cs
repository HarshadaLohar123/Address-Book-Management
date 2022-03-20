using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC_1_Program uc_5 = new UC_1_Program();

            while (true)
            {
                Console.WriteLine("\nSelect Any one Operation: ");
                Console.WriteLine("1. To Add New Person: ");
                Console.WriteLine("2. To Display Contacts: ");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    case 1:
                        PersonDetail person = new PersonDetail();
                        Console.WriteLine("Enter First Name: ");
                        string fname = Console.ReadLine();
                        person.FirstName = fname;
                        Console.WriteLine("Enter Last Name: ");
                        string lname = Console.ReadLine();
                        person.LastName = lname;
                        Console.WriteLine("Enter Address ");
                        string address = Console.ReadLine();
                        person.Address = address;
                        Console.WriteLine("Enter City: ");
                        string city = Console.ReadLine();
                        person.City = city;
                        Console.WriteLine("Enter State: ");
                        string state = Console.ReadLine();
                        person.State = state;
                        Console.WriteLine("Enter pin code: ");
                        int pin = int.Parse(Console.ReadLine());
                        person.Zip = pin;
                        Console.WriteLine("Enter Phone Number: ");
                        long number = long.Parse(Console.ReadLine());
                        person.PhoneNumber = number;
                        Console.WriteLine("Enter Email id: ");
                        string email = Console.ReadLine();
                        person.Email = email;
                        uc_5.addPerson(person);
                        break;

                    case 2:
                        uc_5.Display();
                        break;
                }
            }


        }
    }
}
