using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockroachRuns
{
    class Program
    {
        static void Main(string[] args)
        {
            RoachTable.Table = new List<RoachInfo>();
            RoachTable.Table.Add(new RoachInfo { Cockroach = new Cockroach(5), Runned = 0 });
            RoachTable.Table.Add(new RoachInfo { Cockroach = new Cockroach(6), Runned = 0 });
            RoachTable.Table.Add(new RoachInfo { Cockroach = new Cockroach(7), Runned = 0 });
            RoachTable.StartRuns();
        }
    }
}
