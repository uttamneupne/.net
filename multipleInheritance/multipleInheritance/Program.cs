using System;
using static System.Console;
namespace multipleinheritanceeg
{
    public interface IFirst { void FirstMethod(); }
    public interface ISecond { void SecondMethod(); }

    public class First : IFirst
    {
        public void FirstMethod() { Console.WriteLine("First"); }
    }

    public class Second : ISecond
    {
        public void SecondMethod() { Console.WriteLine("Second"); }
    }

    public class FirstAndSecond : IFirst, ISecond
    {
        First first = new First();
        Second second = new Second();
        public void FirstMethod() { first.FirstMethod(); }
        public void SecondMethod() { second.SecondMethod(); }
    }
}