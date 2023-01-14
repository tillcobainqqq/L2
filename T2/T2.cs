using System;

namespace T2
{
    internal class T2
    {
        static void Main(string[] args)
        {
            Console.Write("Array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Input " + i + " element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] sum = new int[] { 0, 0, 0, 0 };

            for (int i = 0; i < k; i++)
            {
                Function(arr);
                Console.Write("Rotated[" + i + "]: ");
                for (int l = 0; l < arr.Length; l++)
                {
                    Console.Write(arr[l] + " ");
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Sum: ");

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }

        static int Function(int[] arr)
        {
            int end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                end = arr[arr.Length - 1];
            }

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = end;

            return arr[arr.Length - 1];
        }
    }
}
