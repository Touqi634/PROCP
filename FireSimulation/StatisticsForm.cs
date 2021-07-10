using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FireSimulation
{
    public partial class StatisticsForm : Form
    {
        //int survived = 0;
        //int count = 0;

        public StatisticsForm(List<Results> results, string time, double people, List<int> exits)
        {
            InitializeComponent();
            //// Horizontal bar chart
            ////Create a chart area and add it to the chart
            //ChartArea area = new ChartArea("First");
            //chart1.ChartAreas.Add(area);
            //area.AxisX.Title = "People";
            //area.AxisY.Title = "Escaped";
            ////Create a series using the data
            //Series barSeries = new Series();
            //barSeries.Points.DataBindXY(xData, yData);
            ////Set the chart type, Bar; horizontal bars
            //barSeries.ChartType = SeriesChartType.Bar;
            ////Assign it to the required area
            //barSeries.ChartArea = "First";
            ////Add the series to the chart
            //chart1.Series.Add(barSeries);
            ////Vertical bar chart
            ////create another area and add it to the chart
            //ChartArea area2 = new ChartArea("Second");
            //chart1.ChartAreas.Add(area2);
            //area2.AxisX.Title = "People";
            //area2.AxisY.Title = "Escaped";
            ////Create the series using just the y data
            //Series barSeries2 = new Series();
            //barSeries2.Points.DataBindY(yData);
            ////Set the chart type, column; vertical bars 
            //barSeries2.ChartType = SeriesChartType.Column;
            //barSeries2.ChartArea = "Second";
            ////Add the series to the chart
            //chart1.Series.Add(barSeries2);



            try
            {
                int simtime = Convert.ToInt32(time);
           

            double avgsurvived = Math.Round((results[results.Count - 1].people / people) * 100);
            

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisY.Title = "People";
            chart.AxisX.Title = "Time";


            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = Convert.ToDouble(results[results.Count - 1].people);
            chart.AxisX.Minimum = 0;
            //chart.AxisX.Maximum = 60;
            chart.AxisY.Interval = 2;
            chart.AxisX.Interval = 1;

            chart1.Series.Add("People Survived");
            chart1.Series["People Survived"].ChartType = SeriesChartType.Line;
            chart1.Series["People Survived"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;



            int counter = 0;
            chart1.Series["People Survived"].Points.AddXY(counter, 0);

            foreach (Results res in results)
            {
                chart1.Series["People Survived"].Points.AddXY(res.clearedTime, res.people);
            }

            lblSurvivalRate.Text += avgsurvived.ToString() + "%";
            lblGradeResult.Text = CalculateGrade(avgsurvived);
            lblSurvived.Text = results[results.Count -1].people.ToString() + " survived out of " + people.ToString() + " under " + simtime.ToString() + " minutes.";

            exitStatus(exits);
            }
            catch (System.FormatException e) { }

        }

        private void exitStatus(List<int> exitss)
        {
            int bestExit = exitss.IndexOf(exitss.Max());
            LabelExit.Text = "Exit " + Convert.ToInt32(bestExit + 1);
            labelExitDetails.Text = "Exit "+ Convert.ToInt32(bestExit + 1)+" had the most escapees with "+exitss[bestExit].ToString()+" Escapees, And is therefore the best exit to set as the emergency one.";
            this.chartExitEscapees.Series["Escapees"].Points.AddXY("Exit 1", exitss[0]);
            this.chartExitEscapees.Series["Escapees"].Points.AddXY("Exit 2", exitss[1]);
            this.chartExitEscapees.Series["Escapees"].Points.AddXY("Exit 3", exitss[2]);
        }

        public string CalculateGrade(double avgsurvived)
        {
            if(avgsurvived >= 1 && avgsurvived <= 30)
            {
                return "Low";
            }
            else if (avgsurvived >= 31 && avgsurvived <= 49)
            {
                return "Below Average";
            }
            else if (avgsurvived >= 50 && avgsurvived <= 60)
            {
                return "Moderate";
            }
            else if (avgsurvived >= 70 && avgsurvived <= 79)
            {
                return "Good";
            }
            else
            {
                lblGradeResult.ForeColor = Color.ForestGreen;
                return "Very Good";
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BttnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Form form3 = Application.OpenForms["PopUp"];
                form3.BringToFront();
            }
            catch (System.NullReferenceException ce) { }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
