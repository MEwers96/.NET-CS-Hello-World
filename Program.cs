using System;
using System.Threading;
using myQueue;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(5000);
            Console.WriteLine("Time to initiate a Queue!...");
            Thread.Sleep(2500);
            Console.WriteLine("Adding String 'Hello' to the Queue");

            Queue q = new Queue();
            q.add("Hello");
            Console.WriteLine("Adding String 'World' to the Queue");
            Thread.Sleep(2500);
            q.add("World");
            Console.WriteLine("Adding String 'Foo' to the Queue");
            Thread.Sleep(2500);
            q.add("Foo");

            Console.WriteLine("Popping out of the Queue");
            Thread.Sleep(2500);
            q.pop();

            Console.WriteLine("Popping out of the Queue");
            Thread.Sleep(2500);
            q.pop();

            Console.WriteLine("Adding String 'Bar' to the Queue");
            Thread.Sleep(2500);
            q.add("Bar");

            Console.WriteLine("Popping out of the Queue");
            Thread.Sleep(2500);
            q.pop();

            Console.WriteLine("Popping out of the Queue");
            Thread.Sleep(2500);
            q.pop();

            Console.WriteLine("Popping out of the Queue");
            Thread.Sleep(2500);
            q.pop();
        }
    }
}
