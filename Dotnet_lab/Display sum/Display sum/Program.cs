using System;

namespace sumoftwo 
{
    class Program
    {
       static void Main(string[] args)
    {
        int num1, num2, result;
        Console.WriteLine("enter the number1");
        num1 =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the number2");
        num2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is");
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
    }
    }
}