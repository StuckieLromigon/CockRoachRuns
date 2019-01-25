using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CockroachRuns
{
    static class RoachTable
    {
        public static List<RoachInfo> Table { get; set; }

        public static void StartRuns()
        {
            RoachTimer.Start();
            for (int i = 0; i < Table.Count; i++)
            {
                ParameterizedThreadStart pts = new ParameterizedThreadStart(RunRoachRun);
                Thread roachRun = new Thread(pts);
                roachRun.Start(i);
            }
            Console.ReadKey();
        }

        public static void RunRoachRun(object roachNumber)
        {
            Cockroach cockroach = Table[(int)roachNumber].Cockroach;
            while(true)
            {
                Table[(int)roachNumber].Runned += Table[(int)roachNumber].Cockroach.Speed;
                Thread.Sleep(1000);
            }
        }
    }
}
