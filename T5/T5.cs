using System;

namespace T5
{
    internal class T5
    {
        static void Main(string[] args)
        {
            Console.Write("1 array size: ");
            int n1 = int.Parse(Console.ReadLine());
            char[] arr1 = new char[n1];

            Console.WriteLine();

            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Input " + i + " element of array: ");
                arr1[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Array 1: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("2 array size: ");
            int n2 = int.Parse(Console.ReadLine());
            char[] arr2 = new char[n2];

            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("Input " + i + " element of array: ");
                arr2[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Array 2: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Result: ");
            Function(arr1, arr2);
        }

        static void Function(char[] a, char[] b)
        {
            int n;
            int count = 0;

            //length check
            if (a.Length > b.Length)
            {
                n = b.Length;
            }
            else if (a.Length < b.Length)
            {
                n = a.Length;
            }
            else
            {
                n = a.Length;
            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] == b[i])
                {
                    count++;
                }
                else
                {
                    if (a[i] < b[i])
                    {
                        for (int j = 0; j < a.Length; j++)
                        {
                            Console.Write(a[j]);
                        }

                        Console.WriteLine();

                        for (int j = 0; j < b.Length; j++)
                        {
                            Console.Write(b[j]);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            Console.Write(b[j]);
                        }

                        Console.WriteLine();

                        for (int j = 0; j < a.Length; j++)
                        {
                            Console.Write(a[j]);
                        }
                    }
                    break;
                }
            }

            if (count == n)
            {
                if (a.Length == n)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        Console.Write(a[j]);
                    }

                    Console.WriteLine();

                    for (int j = 0; j < b.Length; j++)
                    {
                        Console.Write(b[j]);
                    }
                }
                else if (b.Length == n)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        Console.Write(b[j]);
                    }

                    Console.WriteLine();

                    for (int j = 0; j < a.Length; j++)
                    {
                        Console.Write(a[j]);
                    }
                }
            }
        }
    }
}
