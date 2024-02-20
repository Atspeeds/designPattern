using System;
using BuilderDP.AbstractBuilder;
using BuilderDP.ClientBuilder;
using BuilderDP.ConcreateBuilder;

namespace BuilderDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenuBuilder menuBuilder = new MenuBuilder();
            var dirctor = new MenuDirector(menuBuilder);

            dirctor.ConstructMenu("1", "Menue1", "AmirKharazi");

            var menue = menuBuilder.GetMenu();

            Console.WriteLine($"id:{menue.Id}   Name:{menue.Name}  Link:{menue.Link}");


            //------------------------MenuTWo-------------------------------------

            menuBuilder = new MenuBuilderTwo();
            var dirctor2 = new MenuDirector(menuBuilder);
            dirctor2.ConstructMenu2("Menue2", "AmirAm");
            var menue2 = menuBuilder.GetMenu();
            Console.WriteLine($"id:{menue2.Id}   Name:{menue2.Name}  Link:{menue2.Link}");

        }
    }
}
