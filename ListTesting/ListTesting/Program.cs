using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTesting
{
    class Program
    {
        static void Main()
        {
            //List<int> listOfIntegers;
            //listOfIntegers = new List<int>() { 1, 2, 3, 4 };
            //Console.WriteLine(listOfIntegers.Capacity);
            //Console.WriteLine(listOfIntegers.Count);
            //Console.WriteLine(listOfIntegers[3]);
            //listOfIntegers.TrimExcess();

            //Console.WriteLine("Please enter a number to check against the data!");

            //string userAnswer = Console.ReadLine();

            //int checkedAnswer;

            //try
            //{
            //    checkedAnswer = Convert.ToInt32(userAnswer);
            //} catch {
            //    Console.WriteLine("Apologies, mate. That's not a number.");
            //    return;
            //}

            //bool bigAnswer = listOfIntegers.Contains(checkedAnswer);

            //Console.WriteLine(bigAnswer);

            for (int i = 1; i >= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
