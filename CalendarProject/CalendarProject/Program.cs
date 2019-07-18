using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCalendar(31, 7);
        }

        static void PrintCalendar(int totalDays, int lineCount)
        {
            for(int i = 1; i <= totalDays; i++)
            {
                Console.Write("  " + i + "  ");

                if (0 == i % lineCount)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
