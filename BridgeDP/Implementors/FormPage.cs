using System;

namespace BridgeDP.Implementor
{
    public class FormPage : IWebPage
    {
        public void GetColor(string color)
        {
            if (color == "red")
            {
                Console.WriteLine("Form Red");
            }
            if (color == "dark")
            {
                Console.WriteLine("Form Dark");
            }
        }
    }


}
