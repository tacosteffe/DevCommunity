using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace OOPnDOP.OOP
{
    public class OOPMain
    {
        public OOPMain()
        {
        }


        public void DataSpeed()
        {
            List<IItem> items = new();
            IItem[] items2 = new IItem[10000000];

            //Skapa upp 10,000,000 objekt med lite data i sig
            for (int i = 0; i < 10000000; ++i)
            {
                items.Add(new Item2());

                items2[i] = new Item3();
            }


            Console.WriteLine($"Press to start\n");
            Console.ReadKey();







            //=========================








            StopWatchIt.TimeIt(() =>
            {
                foreach (IItem it in items)
                {
                    it.WorkData();
                }
            }, "OOP Foreach");

            Console.ReadKey();









            //=========================









            StopWatchIt.TimeIt(() =>
            {
                int count = items2.Length;
                for (int i = 0; i < count; ++i)
                {
                    items2[i].WorkData();
                }
            }, "OOP For int using structs");

            Console.ReadKey();
        }


        public void Animals()
        {
            AnimalsShow.NameTheAnimals();
        }



    }
}
