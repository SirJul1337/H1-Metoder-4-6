using System;

namespace Metoder_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 10;
            int startUpDown = 1;
            int midUpDown = 32;
            int endUpDown = 16;
            string countUpResult = CountUp(startNumber,endNumber);
            string countDownResult = CountDown(startNumber,endNumber);
            string countUpDownResult = CountUpDown(startUpDown, midUpDown, endUpDown);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 to 10 \n");
            Console.WriteLine(countUpResult);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("10 to 1\n");
            Console.WriteLine(countDownResult);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("0 to 32 to 16\n");
            Console.WriteLine(countUpDownResult);
        }
        public static string CountUp(int start, int stop)
        {
            string output = "";
            for(int i = start; i <= stop; i++)
            {
                output += i + "\n";
            }
            return output;
        }
        public static string CountDown(int start, int stop)
        {
            string output = "";
            for(int i = stop; i >= start; i--)
            {
                output += i + "\n";

            }
            return output;
        }
        public static string CountUpDown(int start, int mid, int end)
        {
            string output= "";
            for(int i = start; i <= mid; i++)
            {
                output += i + "\n";
            }
            for (int i = mid; i >= end; i--)
            {
                output += i + "\n";
            }
            return output;
        }
    }
}
