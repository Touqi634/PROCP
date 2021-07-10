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
    public partial class PopUp : Form
    {
        public StatisticsForm Statistics;
        List<Results> results;
        List<int> exits;
        string time;
        int people;
        


        public PopUp(List<Results> results, string time, int initial_people, List<int> escapees)
        {
            InitializeComponent();
            try
            {
                this.results = results;
                this.time = time;
                this.people = initial_people;
                this.exits = escapees;
                lblSurvived.Text += results[results.Count - 1].people.ToString();
                lblTime.Text += time;
            }
            catch (System.ArgumentOutOfRangeException e) { }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Statistics = new StatisticsForm(results, time,people,exits);
            Close();
            Statistics.Show();
        }

        private void BttnBack_Click(object sender, EventArgs e)
        {
            Form form2 = Application.OpenForms["Simulation"];
            form2.BringToFront();
        }

        private void BttnFront_Click(object sender, EventArgs e)
        {
            Form form4 = Application.OpenForms["StatisticsForm"];
            try
            {
                form4.BringToFront();
            }
            catch (Exception)
            {
            }
        }
    }
}
