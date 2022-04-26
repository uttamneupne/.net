using System;
using System.Collections;
namespace s_push
{
    class program
    {
        static void Main(string[] args)
        {
            Stack st=new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            foreach(object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("The number of elements in stack" + st.Count);
            Console.WriteLine("Does the stack contain the element 3" + st.Contains(3));
            Console.ReadLine();
        }
    }
}