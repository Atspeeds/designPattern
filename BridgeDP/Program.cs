using BridgeDP.Abstraction;
using BridgeDP.Abstractions;

namespace BridgeDP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AbstractionWeb abstraction = new ConcreteAbstraction();

            abstraction.GetColor("red");

        }
    }


}
