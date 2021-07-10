using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            homePageControl1.BringToFront();
            button1.BringToFront();
        }

        
        private void BttnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bttnHome.Height;
            SidePanel.Top = bttnHome.Top;
            homePageControl1.BringToFront();
        }

        private void BttnHistory_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bttnHistory.Height;
            SidePanel.Top = bttnHistory.Top;
            historyControl11.BringToFront();
        }

        private void BttnAboutUs_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bttnAboutUs.Height;
            SidePanel.Top = bttnAboutUs.Top;
            aboutUsControl11.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button2.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BttnFront_Click(object sender, EventArgs e)
        {
            Form form2 = Application.OpenForms["Simulation"];
            try
            {
                form2.BringToFront();
            }
            catch (Exception)
            {
            }
        }
    }
}
