﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        public static object Sample { get; private set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Address Book System!");
            Createacontact.GetCustomer();
            AddressBook.Createacontact.Modify();
            Createacontact.ListingPeople();
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    Sample.Createacontact.GetCustomer();
                    Sample.Createacontact.ListingPeople();
                    break;
                case "2":
                    Sample.Createacontact.GetCustomer();
                    Sample.Createacontact.Modify();
                    Sample.Createacontact.ListingPeople();
                    break;
                case "3":
                    Sample.Createacontact.GetCustomer();
                    Sample.Createacontact.ListingPeople();
                    break;
                case "4":
                    Sample.Createacontact.GetCustomer();
                    Sample.Createacontact.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;






            }




        }
    }
}

