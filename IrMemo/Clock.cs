using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrMemo
{
    internal class Clock
    {
        public string StopatchTimer(int a)
        {
            int TimeMin = a / 60;
            int TimeSec = a % 60;
            string Time = TimeMin + ":" + TimeSec;
            return Time;
        }
    }
}
