using System;
using System.Threading;
using CommandDP.Commands;

namespace CommandDP
{
    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }
        public void Execute(int command)
        {
            Counter(command);
        }

        private void Counter(int command)
        {

            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(2000);
                if (command == 1)
                {
                    Console.WriteLine($"Number:{i} \n");
                }

                else if (command == 0)
                {
                    break;
                }

            }
        }


    }



}
