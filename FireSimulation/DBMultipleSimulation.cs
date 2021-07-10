using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
    public class DBMultipleSimulation
    {
        public int id;
        public string floor_plan;
        public string time_stamp;

        public DBMultipleSimulation(int id, string floor_plan, string time_stamp)
        {
            this.id = id;
            this.floor_plan = floor_plan;
            this.time_stamp = time_stamp;
        }
    }
}
