using RoyT.AStar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
    public class Fire
    {
        public Position location { get; set; }

        public int Intensity { get; set; }

        public PictureBox PixtureBox { get; set; }

        public int injured = 0; 

        public Fire(int intencity, PictureBox pixtureBox)
        {
            this.Intensity = intencity;
            this.PixtureBox = pixtureBox;
            this.location = new Position(pixtureBox.Location.X / 20, (pixtureBox.Location.Y - 50) / 20);
        }

    }
}
