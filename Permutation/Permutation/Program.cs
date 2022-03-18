using System;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 5, 2, 3, 4, 1 };
            Perm(arr, 0, arr.Length, arr.Length);
        }

        static void Perm(int[] arr, int depth, int n, int k)
        {
            if(depth == k)
            {
                for(int i=0; i < k; i++)
                {
                    if (i == k - 1)
                        Console.WriteLine(arr[i]);
                    else
                        Console.Write(arr[i] + ",");
                    
                }
                
                return;
            }
            
            for(int i=depth; i < n; i++)
            {
                swap(arr, i, depth);
                Perm(arr, depth + 1, n, k);
                swap(arr, i, depth);
            }
        }

        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
