using System;
using System.Threading;
using myQueue;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {
            
            
            Console.WriteLine("Hello World!");
            Thread.Sleep(2000);
            Console.WriteLine("Time to initiate a Queue!...");
            Thread.Sleep(2000);
            Queue q = new Queue();
            Console.WriteLine("to add to the queue please type 'push word'.\nto pop from the queue please type 'pop'.\nto stop the program, please type 'stop'.");
            while (true)
            {
                Console.WriteLine("please type a command:\n");
                String addToQueue = Console.ReadLine();
                if(addToQueue == "stop")
                {
                    break;
                }
                else if(addToQueue.Split()[0] == "push")
                {

                    q.push(addToQueue.Split()[1]);
                    Console.WriteLine("'{0}' has been added to the queue.", addToQueue.Split()[1]);
                }
                else if(addToQueue.Split()[0] == "pop")
                {
                    String removedWord = q.pop();
                    if(removedWord == "NULL")
                    {
                        continue;
                    }
                    Console.WriteLine("'{0}' has been removed from the queue.", removedWord);
                    
                }
                else
                {
                    Console.WriteLine("Please try again....");
                }


            }


            /* Below is a quick and fun Palindrome checker!
            
            while (true)
            {
                int count = 0;
                Console.WriteLine("Please enter a palindrome...\n");
                String palindrome = Console.ReadLine();
                if(palindrome == "stop")
                {
                    break;
                }
                for (int i = 0; i < palindrome.Length / 2; i++)
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


            /* Below is a simple string reversal 
             

            Console.WriteLine("Please enter a word to be reversed...\n");
            String reverse = Console.ReadLine();
            char[] newString = reverse.ToCharArray();

            
            for(int i = 0; i < reverse.Length/2; i++)
            {
                char temp = newString[i];
                newString[i] = newString[reverse.Length - 1 - i];
                newString[reverse.Length - 1 - i] = temp;
            }
            String result = new string(newString);
            Console.WriteLine("The reversed version of '{0}' is '{1}'", reverse, result);

    */
            return 0;
        }
    }
}
