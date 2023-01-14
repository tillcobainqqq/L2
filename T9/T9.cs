using System;

namespace T9
{
    internal class T9
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];
            for(int i = 97, j = 0; i < 123; i++, j++)
            {
                arr[j] = (char)i;
            }

            Console.Write("Array size: ");
            int n = int.Parse(Console.ReadLine());
            char[] arr1 = new char[n];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Input " + i + " element of array: ");
                arr1[i] = char.Parse(Console.ReadLine());
            }

            Function(arr, arr1);
        }

        static void Function(char[] a, char[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i] == a[j])
                    {
                        Console.WriteLine(b[i] + "->" + j);
                    }
                }
            }
        }
    }
}
