using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
   public class DBExit
    {
        int id;
        int Sim_ID;
        int Exitors;

        public DBExit(int id, int Sim_ID, int Exitors)
        {
            this.id = id;
            this.Sim_ID = Sim_ID;
            this.Exitors = Exitors;
        }
    }
}
