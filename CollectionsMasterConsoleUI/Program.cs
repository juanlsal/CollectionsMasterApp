using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            var numberArray = new int[50];
            Populater(numberArray);
            Console.WriteLine($"First Number: {numberArray[0]}");          
            Console.WriteLine($"Last Number: {numberArray[49]}");
            Console.WriteLine("All Numbers Original");
            NumberPrinter(numberArray);
            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Reversed\n");
            Array.Reverse(numberArray);
            NumberPrinter(numberArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(numberArray); //returning numberCollection default state
            ReverseArray(numberArray);
            Console.WriteLine("-------------------");
            Console.WriteLine("Multiple of three = 0: \n");
            ThreeKiller(numberArray);
            Console.WriteLine("-------------------");        
            Console.WriteLine("Sorted numbers:\n");
            Array.Sort(numberArray);
            NumberPrinter2(numberArray);
            Console.WriteLine("\n************End Arrays***************\n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");
            var numberList = new List<int>();
            Console.WriteLine(numberList.Capacity);          
            Populater(numberList);
            Console.WriteLine(numberList.Capacity);
            Console.WriteLine(numberList.Count);
            Console.WriteLine("---------------------");
            Console.WriteLine("What number will you search for in the number list?");
            var numberSearch = Convert.ToInt32(Console.ReadLine());
            NumberChecker(numberList, numberSearch);
            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers:");
            NumberPrinterList(numberList);
            Console.WriteLine("-------------------");
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            Console.WriteLine("------------------");
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("------------------");
            var newNumberArray = numberList.ToArray();
            numberList.Clear();
            #endregion
        }

        private static void ThreeKiller(int[] arrayName)
        {
            for (var i = 0; i < arrayName.Length; i++)
            {
                if (arrayName[i] % 3 == 0)
                {
                    arrayName[i] = 0;
                }
                Console.WriteLine(arrayName[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 == 1)
                {
                    numberList.RemoveAt(i);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Your number, {searchNumber}, is in the list!");
            }
            else
            {
                Console.WriteLine($"Your number, {searchNumber}, is not in the list...");
            }
            

        }

        private static void Populater(List<int> listName)
        {
            Random num = new Random();

            for (var i = 0; i < 50; i++)
            {
                var newNumber = num.Next(1, 51);
                listName.Add(newNumber);
            }
        }

        private static void Populater(int[] arrayName)
        {
            Random num = new Random();

            for (var i = 0; i < arrayName.Length; i++)
            {
                arrayName[i] = num.Next(1, 51);
            }


        }        

        private static void ReverseArray(int[] arrayName)
        {
            Array.Reverse(arrayName);
            NumberPrinter(arrayName);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private static void NumberPrinter2(int[] arrayName)
        {
            foreach (var item in arrayName)
            {
                Console.WriteLine(item);
            }
        }

        private static void NumberPrinter3(int[] arrayName)
        {
            for (var i = 0; i < arrayName.Length; i++)
            {
                Console.WriteLine(arrayName[i]);
            }
        }

        private static void NumberPrinterList(List<int> listName)
        {
            foreach (var item in listName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
