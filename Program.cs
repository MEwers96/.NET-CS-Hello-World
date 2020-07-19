using System;
using System.Threading;
using HelloWorld;

namespace HelloWorld
{
    public class Program
    {
        public static int Main(string[] args)
        {
            
            
            Console.WriteLine("Hello World!");
            Thread.Sleep(2000);
            Console.WriteLine("Time to initiate a Queue!...");
            Thread.Sleep(2000);
            var q = new Queue();
            Console.WriteLine("to add to the queue please type 'push word'.\nto pop from the queue please type 'pop'.\nto stop the program, please type 'stop'.");
            while (true)
            {
                Console.WriteLine("please type a command:\n");
                var addToQueue = Console.ReadLine();
                switch (addToQueue.Split()[0])
                {
                    case "stop":
                        return 0;

                    case "push":
                        q.Push(addToQueue.Split()[1]);
                        Console.WriteLine("'{0}' has been added to the queue.", addToQueue.Split()[1]);
                        break;
                    case "pop":
                        var removedWord = q.Pop();
                        if (removedWord == "NULL")
                        {
                            continue;
                        }

                        Console.WriteLine("'{0}' has been removed from the queue.", removedWord);
                        break;
                    default:
                        Console.WriteLine("Please try again....");
                        break;


                }
            }


            /* Below is a quick and fun Palindrome checker!
            
            while (true)
            {
                var count = 0;
                Console.WriteLine("Please enter a palindrome...\n");
                var palindrome = Console.ReadLine();
                if(palindrome == "stop")
                {
                    break;
                }
                for (var i = 0; i < palindrome.Length / 2; i++)
                {
                    if (palindrome[i] == palindrome[palindrome.Length - 1 - i])
                    {
                        count++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("'{0}' is not a Palindrome. Please try again.", palindrome);
                        break;
                        
                        
                    }
                }
                if(count == palindrome.Length / 2)
                {
                    Console.WriteLine("{0} is a palindrome! congratz!", palindrome);
                }
                {

                }
            }*/

            /*
             Below is a simple string reversal 
             

            Console.WriteLine("Please enter a word to be reversed...\n");
            var reverse = Console.ReadLine();
            var newString = reverse.ToCharArray();

            
            for(var i = 0; i < reverse.Length/2; i++)
            {
                var temp = newString[i];
                newString[i] = newString[reverse.Length - 1 - i];
                newString[reverse.Length - 1 - i] = temp;
            }
            var result = new string(newString);
            Console.WriteLine("The reversed version of '{0}' is '{1}'", reverse, result);

    */
            
        }
    }
}
