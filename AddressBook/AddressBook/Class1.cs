﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class PersonDetail
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public long PhoneNumber;
        public string Email;

        public string Result()
        {
            return "Name is: " + FirstName + LastName + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + Zip + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }
    internal class UC_1_Program
    {
        public List<PersonDetail> person = new List<PersonDetail>();

        public void Display()
        {
            Console.WriteLine("Welcome to Program");
            foreach (PersonDetail per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void addPerson(PersonDetail p)
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\Bridgelabz\Visual Studio Assignment\Address-Book-Management\Address-Book-Management\AddressBook\AddressBook\Details.json", jsonData);
        }

        public UC_1_Program()
        {
            string json = File.ReadAllText(@"D:\Bridgelabz\Visual Studio Assignment\Address-Book-Management\Address-Book-Management\AddressBook\AddressBook\Details.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<PersonDetail>>(json);
            }
            else
                person = new List<PersonDetail>();
        }

    }


}