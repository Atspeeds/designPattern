using System;

namespace FlyweightDP.Services
{
    public class FirstClassSoldier : ISoldier
    {
        public string Degree { get; set; }

        public void Location(int x, int y)
        {
            Console.WriteLine("There is a FirstClass Soldier in Location {0} --- {1}", x, y);
        }
    }



}
