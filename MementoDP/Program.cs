using MementoDP.Entity;
using MementoDP.Mementos;

namespace MementoDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new CarGame();
            car.Name = "Pried";
            car.RouteLocation = "Sabzevar";

            CareTaker taker = new CareTaker();

            taker.Memento = car.CreateMemento();
            car.Name = "Vanet";
            car.RouteLocation = "Tehran";
            car.Name = "Naesan";
            car.RouteLocation = "Ardbil";
            car.Name = "Benz";
            car.RouteLocation = "Kish";

            car.SetMemento(taker.Memento);


        }
    }

}
