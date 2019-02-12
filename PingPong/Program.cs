using System;

namespace PingPong
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Let's start with a number");
            string input = Console.ReadLine();
            NumberProcessor processor = new NumberProcessor();
            processor.SetInput(input);
            processor.DoTheThing();
        }
    }
}