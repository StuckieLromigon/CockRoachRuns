using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CockroachRuns
{
    static class RoachTimer
    {
        static Timer _timer;

        public static void Start()
        {
            TimerCallback tcb = new TimerCallback(RoachInfoShow);
            _timer = new Timer(tcb, null, 0, 10000);
        }

        public static void RoachInfoShow(object param)
        {
            for (int i = 0; i < RoachTable.Table.Count; i++)
            {
                Console.WriteLine($"Roach number {i+1} runned {RoachTable.Table[i].Runned} meters");
            }
        }
    }
}
