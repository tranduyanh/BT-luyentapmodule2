using System;

namespace ontapmodule2
{

    class Program
    {
        public static int[] array = new int[0];
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1. tao mang");
                Console.WriteLine("2. kiem tra mang doi xung");
                Console.WriteLine("3. sap xep mang");
                Console.WriteLine("4. tim kiem mang");
                Console.WriteLine("5. thoat");

                int choice = int.Parse(Console.ReadLine());
                /* if (choice == 5)
                     break;*/
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("nhap size mang");
                        int size = Convert.ToInt32(Console.ReadLine());
                        array = CreateArray(size);
                        PrintArray(array);
                        break;
                    case 2:
                        if (IsSymmetryArray(array))
                        {
                            Console.WriteLine("la mang doi xung");
                        }
                        else
                        {
                            Console.WriteLine("la mang khong doi xung");
                        }
                        break;
                    case 3:
                        array = SelectionSort(array);
                        PrintArray(array);
                        break;
                    case 4:
                        Console.WriteLine("nhap so can tim kiem: ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Find(array, key));
                        break;
                    case 5:
                        Environment.Exit(choice);
                        break;
                }

            } while (true);
            Console.ReadLine();
        }

        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(30, 60);
            }
            return arr;
        }

        public static bool IsSymmetryArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                int tmp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = tmp;
            }
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static int Find(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] == x)
                    return m;

                if (arr[m] < x)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }

    }
}
