using System;

namespace RotateArrayLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(string.Join(" " ,RotateLeft(a, 2)));
            Console.ReadLine();
        }
        public static int[] RotateLeft(int[] a ,int n)
        {
            int[] temp = a[0..n];
            for(int i=0;i<a.Length-n;i++)
            {
                
                a[i] = a[i + n];
            }
            int l = a.Length-1;
            while(n!=0)
            {
                a[l] = temp[n - 1];
                l--;
                n--;
            }
            return a;
        }
    }
}
