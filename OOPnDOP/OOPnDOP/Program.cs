



using OOPnDOP.OOP;
using OOPnDOP.DOP;

namespace DevCommunity
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("AppStart");

            OOPMain oop = new OOPMain();

            //oop.DataSpeed();
            //oop.Animals();

            DOPMain dop = new DOPMain();

            dop.DataSpeed();


            Console.WriteLine("Done");
            Console.ReadKey();
        }

    }

}