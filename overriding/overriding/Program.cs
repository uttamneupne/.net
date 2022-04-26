using System;

namespace method_Overriding
{
    class Bird
    {
        public virtual void fly()
        {
            Console.WriteLine("Bird are Flying");
        }
    }
    class peacock : Bird
    {
        public override void fly()
        {
            Console.WriteLine("peacock is flying");
        }
        public static void Main(string[] args)
        {
            Bird mybird = new Bird();
            mybird.fly();
            Bird mypeacock = new peacock();
            mypeacock.fly();
        }
    }
}
