using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Program");

            UC_1_Program uC_1 = new UC_1_Program();
            PersonDetail person = new PersonDetail();
            person.FirstName = "Harshada";
            person.LastName = "Lohar";
            person.Address = "Shahada";
            person.City = "Nandurbar";
            person.State = "Maharastra";
            person.Zip= 425409;
            person.PhoneNumber = 4634678632;
            person.Email = "HarshaLohar@gmail.com";
            uC_1.addPerson(person);
            uC_1.Display();
        }
    }
}
    