using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrMemo
{
    internal class Clock
    {
        public string StopatchTimer(int ClockFace)
        {
            int TimeMin = ClockFace / 60;
            int TimeSec = ClockFace % 60;
            string Time = TimeMin + ":" + TimeSec;
            return Time;
        }
    }
}
