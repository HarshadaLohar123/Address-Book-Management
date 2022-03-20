using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBookManagement Program");
            UC_1_Program uC_1_Program = new UC_1_Program();
            PersonDetail person = new PersonDetail();
            person.FirstName = "Harshada";
            person.LastName = "Lohar";
            person.Address = "Shirud Digar";
            person.City = "Shahada";
            person.State = "Maharastra";
            person.Zip = 425409;
            person.PhoneNumber = 35348632;
            person.Email = "HarshaLohar@gmail.com";
            uC_1_Program.addPerson(person);
            uC_1_Program.Display();


        }
    }
}
