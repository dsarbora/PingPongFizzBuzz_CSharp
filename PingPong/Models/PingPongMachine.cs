using System;

namespace PingPong
{
    class NumberProcessor
    {
        public int Input;
        public NumberProcessor()
        {
        }

        public void SetInput(string input)
        {
            Input = int.Parse(input);
        }

        public void DoTheThing()
        {
            for (int i=1; i<=Input; i++)
            {
                if (i %3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("PingPong");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Ping");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Pong");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}