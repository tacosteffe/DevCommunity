using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnDOP.OOP
{
    public class Item : IItem
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Item()
        {
            X = 0;
            Y = 0;
        }

        public Item(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Item2 : Item
    {
        public int Z { get; set; }

        public Item2() : base(1, 2)
        {
            Z = 0;
        }
    }



    public class Data
    {
        List<IItem> Items = new();

        public void CreateData()
        {
            for (int i = 0; i < 5000; ++i)
            {
                if (i < 1000)
                    Items.Add(new Item());
                else if (i > 1000 && i < 2000)
                    Items.Add(new Item(3, 5));
                else
                    Items.Add(new Item2());
            }
        }
    }

    public class DataWork : IDataWork
    {
        public void WorkData<IItem>()
        {
            throw new NotImplementedException();
        }
    }




}
