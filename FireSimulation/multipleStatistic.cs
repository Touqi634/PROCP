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
    public partial class multipleStatistic : Form
    {

       
        List<MultipleResult> result;
        int exit1, exit2, exit3;

        int exit1Count = 0, exit2Count = 0, exit3Count = 0;
        List<int> exits;
        List<int> winnerExit;
        int mostUsed;
        List<float> avgExitUsage;
        List<Fire> MostInjured;
        List<Fire> MostInjuredCopy;
        float cur_exit_avg;
        List<InjuredResults> ResultsInjured;
        List<InjuredResults> FinalResults;

        int extinguuisherCount = 0;
        public multipleStatistic(List<MultipleResult> currentResult)
        {
            InitializeComponent();
            //loadingBar.Visible = false;
            this.result = currentResult;

            winnerExit = new List<int>();
            avgExitUsage = new List<float>();
            MostInjured = new List<Fire>();

            foreach (var MultResult in result)
            {
                exit1 += MultResult.Exit1;
                exit2 += MultResult.Exit2;
                exit3 += MultResult.Exit3;

                winnerExit.Add(MultResult.Exit1);
                winnerExit.Add(MultResult.Exit2);
                winnerExit.Add(MultResult.Exit3);

                    mostUsed = winnerExit.IndexOf(winnerExit.Max());
                    mostUsed += 1;

                if(mostUsed == 1)
                {
                    exit1Count++;
                    cur_exit_avg = ((float)MultResult.Exit1/ (float)MultResult.TotalPeople) * 100;
                }
                else if(mostUsed == 2)
                {
                    exit2Count++;
                    cur_exit_avg = ((float)MultResult.Exit2 / (float)MultResult.TotalPeople) * 100;
                }
                else
                {
                    exit3Count++;
                    cur_exit_avg = ((float)MultResult.Exit3 / (float)MultResult.TotalPeople) * 100;
                }

                
                
                avgExitUsage.Add(cur_exit_avg);
                MostInjured.Add(MultResult.Extin);
                winnerExit.Clear();

            }

            //Create list and add exits to the list
            exits = new List<int>();
            exits.Add(exit1Count);
            exits.Add(exit2Count);
            exits.Add(exit3Count);

            //Determine which exit had the most people
            exitStatus(exits);

            //ExitChart
            addExitChart();

            //InjuredChart
            
            injuredChart();

            //SurvivedChart
            //find the extinguisher
            //FindExtinquisher();
            
        }

        ////private void loadingTimer_Tick(object sender, EventArgs e)
        ////{
        ////    loadingBar.Increment(1);
        ////    if (loadingBar.Value == 100)
        ////    {
        ////        label1.Visible = false;
        ////        loadingBar.Visible = false;
        ////    } 
        ////}

        //private void btnShowResults_Click(object sender, EventArgs e)
        //{
        //    btnShowResults.Hide();
        //    loadingBar.Enabled = true;
        //    loadingBar.Visible = true;
        //    label1.Visible = true;
        //}

        private void chartInjured_Click(object sender, EventArgs e)
        {

        }

        private void addExitChart()
        {
            this.chartMultipleExits.Series["Exits"].Points.AddXY("Exit 1", exit1Count);
            this.chartMultipleExits.Series["Exits"].Points.AddXY("Exit 2", exit2Count);
            this.chartMultipleExits.Series["Exits"].Points.AddXY("Exit 3", exit3Count);
        }

        private void multipleStatistic_Load(object sender, EventArgs e)
        {

        }

        private void chartMultipleExits_Click(object sender, EventArgs e)
        {

        }

        private void chartSurvived_Click(object sender, EventArgs e)
        {

        }

        private void injuredChart()
        {
            int counter = 1;
            foreach (var injured in result)
            {

                this.chartInjured.Series["Injured"].Points.AddXY(counter.ToString(), injured.Injured);
                this.chartInjured.Series["Survived"].Points.AddXY(counter.ToString(), injured.TotalSurvived);
                this.chartInjured.Series["Dead"].Points.AddXY(counter.ToString(), injured.Dead);
                counter++;
            }
        }

        private void buttonPaintExtinquisher_Click(object sender, EventArgs e)
        {
            multipleStatistic.ActiveForm.WindowState = FormWindowState.Minimized;
            Simulation.ActiveForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitStatus(List<int> exitss)
        {
            int bestExit = exitss.IndexOf(exitss.Max());
            float best_avg = avgExitUsage.Average();
            labelAvgUsage.Text = best_avg.ToString() + "%";
            labelAssignedExit.Text = "Exit " + Convert.ToInt32(bestExit + 1);
            labelBestExitDescription.Text = "Exit " + Convert.ToInt32(bestExit + 1) + " had the most usage with " + best_avg.ToString() +"%  overall average usage of"+ " escapees, And is therefore the best exit to set as the emergency one.";
        }


        public void FindExtinquisher()
        {
            MostInjuredCopy = MostInjured;
            ResultsInjured = new List<InjuredResults>();

            //for (int i = 0; i < MostInjured.Count; i++)
            //{
            //    //check if there are any entries in the results list yet
            //    if(ResultsInjured.Count == 0)
            //    {
            //        for (int p = MostInjuredCopy.Count - 1; p >= 0; p--)
            //        {
            //            int local_count = 0;
            //            if (MostInjured[i].location == MostInjuredCopy[p].location)
            //            {
            //                local_count++;

            //            }
            //        }
            //    }
            //    else
            //    {

            //    }


            //}
            bool counted = false;
            foreach (var injured in MostInjured)
            {
                if (ResultsInjured.Count <= 0)
                {
                    int countInjured = 0;
                    Fire CurInjured;
                    foreach (var copy in MostInjuredCopy)
                    {
                        
                        if (injured.location == copy.location)
                        {
                            countInjured++;
                        }
                    }
                    CurInjured = injured;
                    InjuredResults CurrentResults = new InjuredResults(CurInjured, countInjured);
                    ResultsInjured.Add(CurrentResults);

                }
                else
                {
                    foreach (var injResults in ResultsInjured)
                    {

                        if(injResults.flame.location == injured.location)
                        {
                            counted = true;
                        }
                    }

                    if(counted)
                    {

                    }
                    else
                    {
                        //
                        int countInjured = 0;
                        Fire CurInjured;
                        foreach (var copy in MostInjuredCopy)
                        {

                            if (injured.location == copy.location)
                            {
                                countInjured++;
                            }
                        }
                        CurInjured = injured;
                        InjuredResults CurrentResults = new InjuredResults(CurInjured, countInjured);
                        ResultsInjured.Add(CurrentResults);
                    }

                    counted = false;
                }
            }

            ResultsInjured.Sort();
            ResultsInjured.Reverse();
            foreach (var res in ResultsInjured)
            {
                Console.WriteLine(res.flame.location.X.ToString() + " " + res.flame.location.Y + " " + res.number.ToString());
            }

            FinalResults = new List<InjuredResults>();

            if(bigenough(ResultsInjured))
            {
                for (int i = 0; i < extinguuisherCount; i++)
                {
                    FinalResults.Add(ResultsInjured[i]);
                }
            }
            else
            {
                for (int i = 0; i < extinguuisherCount; i++)
                {
                    FinalResults.Add(ResultsInjured[i]);
                }
            }
            

            Console.WriteLine("----------------------------------------------------");
            foreach (var res in FinalResults)
            {
                Console.WriteLine(res.flame.location.X.ToString() + " " + res.flame.location.Y + " " + res.number.ToString());
            }

        }

        public void set_extinguisher_count(int n)
        {
            extinguuisherCount = n;
        }

        private bool bigenough(List<InjuredResults> check)
        {
            if(check.Count >= extinguuisherCount)
            {
                return true;
            }
            else
            {
                extinguuisherCount = check.Count;
                return false;
            }
        }

        public List<InjuredResults> returnExtinquishers()
        {
            return FinalResults;
        }


    }

    public class InjuredResults : IComparable<InjuredResults>
    {
        public InjuredResults(Fire hot, int num)
        {
            this.flame = hot;
            this.number = num;
        }
        public int number { get; set; }
        public Fire flame { get; set; }

        public int CompareTo(InjuredResults other)
        {
            if (this.number > other.number)
                return 1;
            else if (this.number < other.number)
                return -1;
            else
                return 0;
        }
    }
}
