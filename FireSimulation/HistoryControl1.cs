using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
    public partial class HistoryControl1 : UserControl
    {
        public StatisticsForm Statistics { get; private set; }
        string load_id;
        public HistoryControl1()
        {
            InitializeComponent();
            //dgvHistory.DataSource = SqliteDataAcess.LoadResults();
            
            foreach(DBSimulation s in SqliteDataAcess.LoadSimulation())
            {
                dgvHistory.Rows.Add(s.id, s.people, s.survived, s.time, s.fire, s.fire_intensity,s.floor_plan,s.time_stamp);
            }
          
        }

        private void DgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dgvHistory.Rows[e.RowIndex];
            //    ppl.Text = row.Cells["People"].Value.ToString();
            //    srv.Text = row.Cells["Survived"].Value.ToString();
            //    tim.Text = row.Cells["Time"].Value.ToString();
            //    fir.Text = row.Cells["Fire"].Value.ToString();
            //    inte.Text = row.Cells["Fire_Intensity"].Value.ToString();
            //}
        }

        private void HistoryControl1_Load(object sender, EventArgs e)
        {

        }

        private void DgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHistory.Rows[e.RowIndex];

                string sim_id = row.Cells["ID"].Value.ToString();
                load_id = row.Cells["ID"].Value.ToString();
                List<DBExit> exits = SqliteDataAcess.LoadDBExit(Convert.ToInt32(sim_id));
                exi.Text = exits.Count().ToString();
                ppl.Text = row.Cells["People"].Value.ToString();
                srv.Text = row.Cells["Survived"].Value.ToString();
                tim.Text = row.Cells["Time"].Value.ToString();
                fir.Text = row.Cells["Fire"].Value.ToString();
                inte.Text = row.Cells["Fire_Intensity"].Value.ToString();
            }
        }

        private void Fir_Click(object sender, EventArgs e)
        {
            dgvHistory.DataSource = null;
            
        }

        public void refresh()
        {
            dgvHistory.Rows.Clear();
            foreach (DBSimulation s in SqliteDataAcess.LoadSimulation())
            {
                dgvHistory.Rows.Add(s.id, s.people, s.survived, s.time, s.fire, s.fire_intensity, s.floor_plan, s.time_stamp);
            }
        }
        private void BttnOpen_Click(object sender, EventArgs e)
        {
            List<Results> res = SqliteDataAcess.LoadResults(Convert.ToInt32(load_id));


            try
            {
                Statistics = new StatisticsForm(res, tim.Text, Convert.ToDouble(ppl.Text), SqliteDataAcess.LoadExit(Convert.ToInt32(load_id)));
                Statistics.Show();
            }
            catch (System.FormatException ex) 
            {
                
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
