using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnDOP
{
    public struct StopWatchWrap
    {
        private Stopwatch SW;

        public void Start() => SW.Start();
        public long TimeMS => SW.ElapsedMilliseconds;
        public TimeSpan TimeSpan => SW.Elapsed;

    }
}
