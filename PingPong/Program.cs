using System;

namespace PingPong
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Let's start with a number");
            int input = int.Parse(Console.ReadLine());
            NumberProcessor processor = new NumberProcessor();
            processor.SetInput(input);
            
            for (int i = 1; i<=input; ++i)
            {
                Console.WriteLine(processor.DoTheThing(i));
            }
        }
    }
}