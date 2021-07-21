using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class List
    {
        public static void ListDemo()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Insert(2, 11);
            primeNumbers.Remove(3);
            primeNumbers.Contains(5);
            Console.WriteLine("list contains element  ", primeNumbers);
            foreach (int prime in primeNumbers)
            {
                Console.WriteLine("The prime numbers are " + prime);
            }
        }
        public static void UsingArray()
        {

        
            string[] cities = new string[] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);
            
            foreach(string place in favouriteCities)
            {
                Console.WriteLine("The cities are " + place);
                //Accessing list
                Console.WriteLine("Accessing list " +favouriteCities[0]);
            }

        }
    }
}
