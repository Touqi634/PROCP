using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
    class DBFire
    {
        public int id;
        public int result_id;
        public int x;
        public int y;
        public int injured;

        public DBFire(int id, int result_id, int x, int y, int injured)
        {
            this.id = id;
            this.result_id = result_id;
            this.x = x;
            this.y = y;
            this.injured = injured;
        }
    }
}
