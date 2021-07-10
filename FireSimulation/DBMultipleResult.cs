using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
   public class DBMultipleResult
    {
        public int id;
        public int sim_id;
        public int people;
        public int time;
        public int injured;
        public int dead;
        public int exit1;
        public int exit2;
        public int exit3;
        public Fire exitin;
      public DBMultipleResult(int id, int sim_id, int people, int time, int injured, int dead, int exit1, int exit2, int exit3, Fire exitin)
        {
            this.id = id;
            this.sim_id = sim_id;
            this.people = people;
            this.time = time;
            this.injured = injured;
            this.dead = dead;
            this.exit1 = exit1;
            this.exit2 = exit2;
            this.exit3 = exit3;
            this.exitin = exitin;
        }
    }
}
