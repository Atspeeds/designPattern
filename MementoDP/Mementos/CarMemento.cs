namespace MementoDP.Mementos
{
    public class CarMemento
    {
        string name;
        string routeLocation;

        public CarMemento(string name, string routeLocation)
        {
            this.name = name;
            this.routeLocation = routeLocation;
        }

        public string Name { get { return name; } }
        public string RouteLocation { get { return routeLocation; } }
    }

}
