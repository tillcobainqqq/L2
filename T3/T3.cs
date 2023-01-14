using System;

namespace T3
{
    internal class T3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }

            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Result: ");
            Function(arr);
        }

        static void Function(int[] arr)
        {
            int n = 2;
            int[] beginning = new int[n];
            int[] end = new int[n];
            int[] beginningAndEnd = new int[n+n];
            int[] middle = new int[n+n];
            int[] sum = new int[n+n];

            for (int i = 0; i < n; i++)
            {
                beginning[i] = arr[i];
            }

            for (int i = middle.Length + beginning.Length; i < arr.Length; i++)
            {
                end[i - 6] = arr[i];
            }

            for (int j = n - 1, i = 0; i < n; i++, j--)
            {
                beginningAndEnd[i] = beginning[j];
            }

            for (int j = 0, i = n - 1; i >= 0; i--, j++)
            {
                beginningAndEnd[i + n] = end[j];
            }

            for (int i = n; i < arr.Length - n; i++)
            {
                middle[i - n] = arr[i];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = beginningAndEnd[i] + middle[i];
            }

            for (int i = 0; i < beginningAndEnd.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
    }
}
