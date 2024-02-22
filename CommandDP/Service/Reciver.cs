using System;

namespace CommandDP.Service
{
    public class Reciver
    {
        public int TurnOff()
        {
            Console.WriteLine("Counting stopped.....");
            return 0;
        }
        public int TurnOn()
        {
            Console.WriteLine("Counting started.....");
            return 1;
        }
    }



}
