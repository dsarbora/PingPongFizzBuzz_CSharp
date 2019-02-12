using System;

namespace PingPong
{
    public class NumberProcessor
    {
        public int Input;
        public NumberProcessor()
        {
        }

        public void SetInput(int input)
        {
            Input = input;
        }

        public string DoTheThing(int input)
        {
             if (input %3 == 0 && input % 5 == 0)
            {
                return "PingPong";
            }
            else if(input%3==0)
            {
                return "Ping";
            }
            else if(input%5==0)
            {
                return "Pong";
            }
            else
            {
                return input.ToString();
            }
        }
    }
}