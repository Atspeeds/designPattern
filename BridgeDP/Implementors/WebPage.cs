using System;

namespace BridgeDP.Implementor
{
    public class WebPage : IWebPage
    {
        public void GetColor(string color)
        {
            if (color == "red")
            {
                Console.WriteLine("Backgruand Red");
            }
            if (color == "dark")
            {
                Console.WriteLine("Backgruand Dark");
            }

        }

    }


}
