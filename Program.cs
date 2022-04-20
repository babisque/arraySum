using System;

namespace Aula60Exe84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] odd = { 1, 3, 5, 7, 9 };
            int[] pair = { 2, 4, 6, 8, 10 };

            Calculator calcualtor = new Calculator();
            int[] arraySum = Calculator.sumArrays(odd, pair);
            
            foreach (int result in arraySum)
            {
                Console.WriteLine(result);
            }
        }
    }
}
