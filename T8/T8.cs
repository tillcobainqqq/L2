using System;

namespace T8
{
    internal class T8
    {
        static void Main(string[] args)
        {
            Console.Write("Array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Input " + i + " element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Function(arr);
        }

        static void Function(int[] a)
        {
            int n = 0;
            int max = 0;
            int res = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                n = 0;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[i] == a[j])
                    {
                        n++;
                        if (n > max)
                        {
                            max = n;
                            res = a[i];
                        }
                    }
                }
            }

            Console.WriteLine("The number " + res + " is the most frequent (occurs " + max + " times)");

        }
    }
}
