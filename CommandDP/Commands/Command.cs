using CommandDP.Service;

namespace CommandDP.Commands
{
    public abstract class Command
    {
        protected Reciver _rciver;

        protected Command(Reciver rciver)
        {
            _rciver = rciver;
        }

        public abstract int Off();
        public abstract int On();
    }



}
