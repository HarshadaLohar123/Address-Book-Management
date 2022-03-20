using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC_1_Program uc_4 = new UC_1_Program();
            uc_4.Display();
            Console.WriteLine("Enter First name to Delete Item: ");
            string name = Console.ReadLine();
            uc_4.RemovePersonDetail(name);
            uc_4.Display();

        }
    }
}
