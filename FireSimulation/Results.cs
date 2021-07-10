using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
    public class Results
    {
        public int clearedTime;
        public int people;

        public Results(int seconds, int survived)
        {
            this.clearedTime = seconds;
            this.people = survived;
        }
    }
}
