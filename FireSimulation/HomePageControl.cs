using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FireSimulation
{
    public partial class HomePageControl : UserControl
    {
        public Simulation Simulation { get; private set; }
        private SoundPlayer _soundplayer;

        public HomePageControl()
        {
            InitializeComponent();
            _soundplayer = new SoundPlayer();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Simulation = new Simulation();
            Simulation.Show();
        }
    }
}
