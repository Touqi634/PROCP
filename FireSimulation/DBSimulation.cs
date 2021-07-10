using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
   public class DBSimulation
    {
        public int id;
        public int people;
        public int survived;
        public int time;
        public int fire;
        public int fire_intensity;
        public string floor_plan;
        public string time_stamp;

        public DBSimulation(int id, int people, int survived, int time, int fire, int fire_intensity, string floor_plan, string time_stamp)
        {
            this.id = id;
            this.people = people;
            this.survived = survived;
            this.time = time;
            this.fire = fire;
            this.fire_intensity = fire_intensity;
            this.floor_plan = floor_plan;
            this.time_stamp = time_stamp;
        }
    }
}
