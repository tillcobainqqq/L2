using System;

namespace T4
{
    internal class T4
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int max = int.Parse(Console.ReadLine());

            bool[] primes = new bool[max + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(max) + 1; i++)
            {
                if (primes[i - 1])
                {
                    for (int j = (int)Math.Pow(i, 2); j <= max; j += i)
                    {
                        primes[j - 1] = false;
                    }
                }
            }

            Console.WriteLine();

            Console.Write("Result: ");
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i - 1])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
