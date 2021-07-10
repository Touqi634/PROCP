using RoyT.AStar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
    public class GroupPeople
    {

        public int GroupMembers { get; set; }

        public Position location { get; set; }

        public PictureBox PixtureBox { get; set; }


        public GroupPeople(int groupMembers, PictureBox pixtureBox)
        {
            this.GroupMembers = groupMembers;
            this.PixtureBox = pixtureBox;
            this.location = new Position(pixtureBox.Location.X / 20, (pixtureBox.Location.Y - 50) / 20);
        }
    }
}
