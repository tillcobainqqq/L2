using System;

namespace L2
{
    internal class T1
    {
        static void Main(string[] args)
        {
            Console.Write("Count of elements in array 1: ");
            int n1 = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n1];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Input " + i + " element of array: ");
                arr1[i] = Console.ReadLine();   
            }

            Console.Write("Count of elements in array 2: ");
            int n2 = int.Parse(Console.ReadLine());
            string[] arr2 = new string[n2];

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("Input " + i + " element of array: ");
                arr2[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Count of same: " + Function(arr1, arr2));
        }

        static int Function(string[] a1, string[] a2)
        {
            int n1 = 0;
            int n2 = 0;
            int n = 0;

            if (a1.Length < a2.Length || a1.Length == a2.Length)
            {
                for (int i = 0; i < a1.Length; i++)
                {
                    if (a1[i] == a2[i] && a1[i] != " ")
                    {
                        n1++;
                    }
                }
                for (int i = a1.Length - 1; i > 0; i--)
                {
                    if (a1[i] == a2[i] && a1[i] != " ")
                    {
                        n2++;
                    }
                }
            }
            else if (a1.Length > a2.Length)
            {
                for (int i = 0; i < a2.Length; i++)
                {
                    if (a2[i] == a1[i] && a2[i] != " ")
                    {
                        n1++;
                    }
                }
                for (int i = a2.Length - 1; i > 0; i--)
                {
                    if (a2[i] == a1[i] && a2[i] != " ")
                    {
                        n2++;
                    }
                }
            }


            if (n1 > n2)
            {
                n = n1;
            }
            else
            {
                n = n2;
            }

            return n;

        }

    }
}
