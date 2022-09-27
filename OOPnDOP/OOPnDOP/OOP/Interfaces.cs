using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnDOP.OOP
{
    public interface IItem
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    public interface IDataWork
    {
        public void WorkData<IItem>();
    }

    
}
