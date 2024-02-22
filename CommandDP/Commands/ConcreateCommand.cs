using CommandDP.Service;

namespace CommandDP.Commands
{
    public class ConcreateCommand : Command
    {
        public ConcreateCommand(Reciver rciver) : base(rciver)
        {
        }

        public override int Off()
        {
            return _rciver.TurnOff();
        }

        public override int On()
        {
            return _rciver.TurnOn();
        }
    }



}
