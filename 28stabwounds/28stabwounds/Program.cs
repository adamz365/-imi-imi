using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace _28stabwounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message("Ahoj.");
            int[] grades = { 1, 2, 3, 4, 5, 1, 2, 4, 3, 3, 5 };
            int result = CalcAverage(grades);
        }

        static void Message(string message) 
        { 
            Console.WriteLine(message);
        }

        static int CalcAverage(int[] nums)
        {
            float prom;
            foreach (int num in nums)
            {

                prom += num;
            }

            return prom / nums.Length;
        }
    }
}
