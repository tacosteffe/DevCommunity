using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnDOP
{
    public class StopWatchIt
    {
        public static void TimeIt(Action action, string name)
        {
            //quick Warmup, avoid cold data
            for(int i = 0; i < 2; i++)
            {
                action.Invoke();
            }

            Stopwatch sw = Stopwatch.StartNew();
            action.Invoke();
            sw.Stop();

            Console.WriteLine($"{name}\n");
            Console.WriteLine($"Time elapsed milliseconds: {sw.Elapsed.TotalMilliseconds} ");
            Console.WriteLine($"Time elapsed: {sw.Elapsed} \n\n\n");
            Console.WriteLine($"Press to continue\n");
        }

    }
}
