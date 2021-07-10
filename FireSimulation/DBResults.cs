using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
   public class DBResults
    {
        public int sim_id;
        public int clearedTime;
        public int people;

        public DBResults(int sim_id, int seconds, int survived)
        {
            this.sim_id = sim_id;
            this.clearedTime = seconds;
            this.people = survived;
        }
    }
}
