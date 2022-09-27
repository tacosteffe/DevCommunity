using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnDOP.DOP
{
    public class DOPMain
    {

        public void DataSpeed()
        {

            List<Item> items = new List<Item>();

            for(int i = 0; i < 10000000; ++i)
            {
                items.Add(new Item());
            }

            //=======================


            Console.WriteLine($"Press to start\n");
            Console.ReadKey();


            StopWatchIt.TimeIt(() =>
            {
                DataWork dw = new DataWork();

                foreach (Item it in items)
                {
                    dw.WorkData(it);
                }
            }, "DOP Foreach no forced inline");


            Console.WriteLine($"Press to continue\n");
            Console.ReadKey();


            //=======================




            StopWatchIt.TimeIt(() =>
            {
                DataWork dw = new DataWork();

                foreach (Item it in items)
                {
                    dw.WorkDataFI(it);
                }
            }, "DOP Foreach with forced inline");

            Console.WriteLine($"Press to continue\n");
            Console.ReadKey();

            items.Clear();




            //=======================

            double[] Xs = new double[10000000];
            double[] Ys = new double[10000000];
            double[] Zs = new double[10000000];

            StopWatchIt.TimeIt(() =>
            {
                DataWork dw = new DataWork();

                for (int i = 0; i < 10000000; ++i)
                {
                    dw.WorkDataFI(Xs[i], Ys[i], Zs[i]);
                }
            }, "DOP For int, separated data with forced inline");

            Console.ReadKey();



        }



    }
}
