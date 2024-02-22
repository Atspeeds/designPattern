using System;

namespace MementoDP.Mementos
{
    public class CareTaker
    {
        CarMemento carMemento;

        public CarMemento Memento
        {
            get { return carMemento; }
            set { carMemento = value; Console.WriteLine("CareTaker Set Memento"); }
        }
    }

}
