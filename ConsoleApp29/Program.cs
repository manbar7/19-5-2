using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        public static void PrintWhichDay(int Day)
        {

            Enum.TryParse($"{Day}", out WhichDay result);
            Console.WriteLine(result);
            
        }

        public static void WhichDayNumber(WhichDay DayName)
        {
            // Enum.TryParse($"{DayName}", out WhichDay result);
            // Console.WriteLine(result);
            Console.WriteLine((int)DayName);

        }
        static void Main(string[] args)
        {
            Enum.GetNames(typeof(WhichDay)).ToList().ForEach(d => Console.WriteLine(d));
            Console.WriteLine("------------------------------");

            int day = 3;
            string DayName = "Tuesday";
            PrintWhichDay(day);
            Console.WriteLine("----------------");
            WhichDayNumber(WhichDay.Friday);

        }

        

        
    }
}
