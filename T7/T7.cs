using System;

namespace T7
{
    internal class T7
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

            Console.Write("Result: ");
            Function(arr);
        }

        static void Function(int[] a)
        {
            int n = 0;
            int max = 0;
            int number = 0;
            int index = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] + 1 == a[i + 1])
                {
                    n++;
                    if (n > max)
                    {
                        max = n;
                        number = a[i];
                        index = i;
                    }
                }
                else
                {
                    n = 0;
                }
            }

            for (int j = index - max + 1; j <= index + 1; j++)
            {
                Console.Write(a[j] + " ");
            }

        }
    }
}
