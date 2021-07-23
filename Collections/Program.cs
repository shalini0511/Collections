using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collections Demo Problem!!!");
            Console.WriteLine("Enter the option ");
            switch (Console.ReadLine())
            {
                case "1":
                    List.ListDemo();
                    break;
                case "2":
                    SortedList.SortedListDemo();
                    break;
                case "3":
                    Dictionary.DictionaryDemo();
                    break;
                case "4":
                
                    Collections.AddressBook.GetCustomer();
                    Collections.AddressBook.Modify();
                    Collections.AddressBook.ListingPeople();
                    Collections.AddressBook.RemovePeople();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;


            }


        }
    }
}
