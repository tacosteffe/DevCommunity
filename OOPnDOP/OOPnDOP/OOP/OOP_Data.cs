using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace OOPnDOP.OOP
{
    public interface IItem
    {
        public double X { get; set; }
        public double Y { get; set; }
        public void WorkData();
    }






    public class Item : IItem
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Item()
        {
            X = 1;
            Y = 1;
        }

        public Item(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual void WorkData()
        {
            X = (Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X));
            Y = (Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y));
        }
    }







    public class Item2 : Item
    {
        public double Z { get; set; }

        public Item2() : base(1.3, 2.5)
        {
            Z = 3.0;
        }

        public override void WorkData()
        {
            X = (Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X));
            Y = (Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y));
            Z = (Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z));
        }
    }







    public struct Item3 : IItem
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Item3()
        {
            X = 3.0;
            Y = 3.0;
            Z = 3.0;
        }

        public void WorkData()
        {
            X = (Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X));
            Y = (Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y));
            Z = (Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z));
        }
    }
}
