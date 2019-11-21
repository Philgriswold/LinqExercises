using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
            { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            List<string> LFruits = fruits.Where(fruit =>
            {
                bool LFruit = fruit.StartsWith("L");
                return startsWithL
            }).ToList();

            foreach (string fruit in Lfruits)
            {
                Console.WriteLine(fruit);
            }

            // this creates a list of numbers called "numbers"
            List<int> numbers = new List<int>()
            { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };

            //  this creates a list called fourSixMultiples, then the array of numbers is called
            // with "numbers", Where basically filters through the numbers, 
            // num gets an individual number.  
            List<int> fourSixMultiples = numbers.Where(num =>
            {
                // newNumbers should be everything that is a multiple of 4 and 6. ToList adds them
                // to the List, but which List?
                bool newNumbers = num % 4 == 0 || num % 6 == 0;
                return newNumbers;
            }).ToList();

            // this foreach loop basically just gets every individual number in the fourSixMultiples 
            // and prints it to the console.
            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
            };

            List<string> descend = names;
            descend.Sort();
            descend.Reverse();

            Console.WriteLine();
            foreach (var name in descend)
            {
                Console.WriteLine(name);
            }

            List<string> anotherDescend = names.OrderByDescending(name => name).ToList();
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.WriteLine(name);
            }

            List<int> moreNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> orderedNumbers = moreNumbers.OrderBy(num => num).ToList();
            Console.WriteLine();
            foreach (var num in orderedNumbers)
            {
                Console.WriteLine(num);
            }

            moreNumbers.Sort();
            Console.WriteLine();
            foreach (var num in moreNumbers)
            {
                Console.WriteLine(num);
            }

            //Output how many numbers are in the moreNumbers list
            Console.WriteLine($"There are {moreNumbers.Count()} numbers in the moreNumbers List");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };

            Console.WriteLine($"I spent {purchases.Sum()}. Too much!!");
        }
        List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
        double maxPrice = prices.Max();
        Console.WriteLine($"OUR most expensive is worth {prices.Max()}");

             List<int> wheresSquaredo = new List<int>()
            {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
        List<int> NOTPerfectSquares = wheresSquaredo.TakeWhile(num =>
        {
            bool isSquared = Math.Sqrt(num) % 1 == 0;
            return !isSquared;
        }).ToList();

            foreach (var num in NOTPerfectSquares)
            {
                Console.WriteLine(num);
            }

















    List<Customer> customers = new List<Customer>()
                {
                    new Customer() { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                    new Customer() { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                    new Customer() { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                    new Customer() { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                    new Customer() { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                    new Customer() { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                    new Customer() { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                    new Customer() { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                    new Customer() { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                    new Customer() { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
                };

    var groups = customers.Where(c => c.Balance >= 1_000_000)
        .GroupBy(c => c.Bank);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);

                foreach (Customer customer in group)
                {
                    Console.WriteLine($"**** {customer.Name}");
                }
            }
        }
    }
        