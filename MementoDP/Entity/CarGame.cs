using System;
using MementoDP.Mementos;

namespace MementoDP.Entity
{
    public class CarGame
    {
        string name;
        string routeLocation;

        public string Name
        {
            get { return name; }
            set { name = value; Console.WriteLine($"Name Car Set:{name}"); }
        }
        public string RouteLocation
        {
            get { return routeLocation; }
            set { routeLocation = value; Console.WriteLine($"Location Car Set:{routeLocation}"); }
        }

        public CarMemento CreateMemento()
        {
            Console.WriteLine($"Saving CarName:{name} With LastLocation:{routeLocation}");
            return new CarMemento(name, routeLocation);
        }

        public void SetMemento(CarMemento memento)
        {
            Console.WriteLine($"Car With Name:{memento.Name} Restore To Location {memento.RouteLocation}");
            name = memento.Name;
            routeLocation = memento.RouteLocation;
        }



    }

}
