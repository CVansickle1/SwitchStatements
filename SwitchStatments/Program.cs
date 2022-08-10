using System;

namespace SwitchStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello What is your favorite school subject?");
            Console.WriteLine("1: Coding \n2: Math \n3: History \n4: Sports/Gym \n5: Foreign Language \nPlease use 1-5");
            int subject;
            bool nullCheck;
            nullCheck = int.TryParse(Console.ReadLine(), out subject);
            
            while (!nullCheck)
            {
                Console.WriteLine("Please enter 1-5 to choose your favorite subject");
                nullCheck = int.TryParse(Console.ReadLine(), out subject);
            }

            switch (subject)
            {
                case 1:
                    Console.WriteLine("First, solve the problem. Then, write the code.");
                    break;
                
                case 2:
                    Console.WriteLine("The essence of mathematics lies in its freedom.");
                    break;
                
                case 3:
                    Console.WriteLine("There is a history in all men's lives.");
                    break;
                
                case 4:
                    Console.WriteLine("Don’t be afraid of failure.This is the way to succeed.");
                    break;
                
                case 5:
                    Console.WriteLine("Learning another language is not only learning different " +
                        "words for the same things, but learning another way to think about things.");
                    break;
                
                default:
                    Console.WriteLine("Coding is my Favorite! you should try it!");
                    break;
            }


        }
    }
}
