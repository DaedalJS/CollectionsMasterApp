using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] fittyNums = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(fittyNums);

            //Print the first number of the array
            Console.WriteLine($"{fittyNums[0]}");

            //Print the last number of the array    

            Console.WriteLine($"{fittyNums[fittyNums.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(fittyNums);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            
            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(fittyNums);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(fittyNums);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(fittyNums);
            NumberPrinter(fittyNums);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> numsli = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(numsli.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numsli);
            Console.WriteLine($"{numsli.Count} items in list");
            

            //Print the new capacity
            Console.WriteLine(numsli.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int numGiven;
            bool wasNumReceived;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                wasNumReceived = int.TryParse(Console.ReadLine(), out numGiven);
                
            }
            while (wasNumReceived == false);
                NumberChecker(numsli, numGiven);
                    
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numsli);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!! (were removed)");
            OddKiller(numsli);
            NumberPrinter(numsli);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted (after removing) Odds!!");
            numsli.Sort();
            NumberPrinter(numsli);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            
            int[] numsarr = numsli.ToArray();
            NumberPrinter(numsarr);

            //Clear the list
            numsli.Clear();
            Console.WriteLine($"\n {numsli.Count} items in list");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            int teekay;
            for (teekay = 0; teekay < numbers.Length; teekay++) 
            {
            if (numbers[teekay] % 3 == 0) { numbers[teekay] = 0; }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {

            numberList.RemoveAll(i => i % 2 != 0);
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is NOT in the list.");
            }

        }

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
            Random rng = new Random();
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            for (int n = 0; n < numbers.Length; n++)
            {
                Random rng = new Random();
                numbers[n] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
