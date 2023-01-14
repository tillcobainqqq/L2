using System;

namespace T10
{
    internal class T10
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

            Console.Write("Difference: ");
            int d = int.Parse(Console.ReadLine());

            Function(arr, d);
        }

        static void Function(int[] a, int n)
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] + n == a[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
