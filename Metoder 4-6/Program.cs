using System;

namespace Metoder_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 0;
            int endNumber = 10;
            int startUpDown = 0;
            int midUpDown = 32;
            int endUpDown = 16;
            string countUpResult = CountUp(startNumber,endNumber);
            string countDownResult = CountDown(startNumber,endNumber);
            string countUpDownResult = CountUpDown(startUpDown, midUpDown, endUpDown);

            Console.WriteLine(countUpResult);
            Console.WriteLine(countDownResult);
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
