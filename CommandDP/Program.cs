using CommandDP.Commands;
using CommandDP.Service;

namespace CommandDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reciver = new Reciver();
            var concrete = new ConcreateCommand(reciver);
            var inviker = new Invoker();
            inviker.SetCommand(concrete);

            inviker.Execute(concrete.On());

            inviker.Execute(concrete.Off());

        }
    }



}
