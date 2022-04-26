using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array :");
            int size=int.Parse(Console.ReadLine());
            int[] number=new int[size];
            Console.WriteLine("Enter the value os array :");
            for(int i=0; i<size; i++)
            {
                number[i]= int.Parse(Console.ReadLine());
            }
            for (int i=0; i<size; i++)
            {
                Console.WriteLine(number[i] + " ");
            }
            Console.ReadLine();
        }

    }
}