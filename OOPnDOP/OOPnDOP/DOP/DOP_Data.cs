using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace OOPnDOP.DOP
{
    //Plain old data
    public struct Item
    {
        public double X;
        public double Y;
        public double Z;
    }

    public static class DataWork
    {
        public static void WorkData(Item it)
        {
            it.X = (Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X));
            it.Y = (Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y));
            it.Z = (Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z));
        }

        public static void WorkDataFI(Item it)
        {
            it.X = (Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X) / Math.Sqrt(it.X));
            it.Y = (Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y) / Math.Sqrt(it.Y));
            it.Z = (Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z) / Math.Sqrt(it.Z));
        }

        public static void WorkDataFI(double X, double Y, double Z)
        {
            X = (Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X) / Math.Sqrt(X));
            Y = (Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y) / Math.Sqrt(Y));
            Z = (Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z) / Math.Sqrt(Z));
        }
    }





    public struct Transaction
    {
        public string Sender;
        public string Reciever;


    }









}
