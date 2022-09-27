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
                foreach (Item it in items)
                {
                    DataWork.WorkData(it);
                }
            }, "DOP Foreach no forced inline");

            Console.ReadKey();


            //=======================




            StopWatchIt.TimeIt(() =>
            {
                foreach (Item it in items)
                {
                    DataWork.WorkDataFI(it);
                }
            }, "DOP Foreach with forced inline");

            Console.ReadKey();

            items.Clear();




            //=======================

            double[] Xs = new double[10000000];
            double[] Ys = new double[10000000];
            double[] Zs = new double[10000000];

            StopWatchIt.TimeIt(() =>
            {

                for (int i = 0; i < 10000000; ++i)
                {
                    DataWork.WorkDataFI(Xs[i], Ys[i], Zs[i]);
                }
            }, "DOP For int, separated data with forced inline");

            Console.ReadKey();



            //=======================

            //double[] Xs = new double[10000000];
            //double[] Ys = new double[10000000];
            //double[] Zs = new double[10000000];

            //StopWatchIt.TimeIt(() =>
            //{

            //    for (int i = 0; i < 10000000; ++i)
            //    {
            //        DataWork.WorkDataFI(Xs[i], Ys[i], Zs[i]);
            //    }
            //}, "DOP For int, separated data with forced inline");

            //Console.ReadKey();




        }



    }
}
