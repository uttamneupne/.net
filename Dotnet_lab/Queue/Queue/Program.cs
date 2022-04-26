using System;
namespace Queue_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> qt = new Queue<int>();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            qt.Dequeue();
            foreach (object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}