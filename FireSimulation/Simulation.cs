using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Timer = System.Timers.Timer;

namespace FireSimulation
{
    delegate void SetTextCallback(string text);
    public partial class Simulation : Form
    {
        public StatisticsForm Statistics { get; private set; }
        public PopUp pop;

        //Grid Size Variables
        private Graphics graphics;
        const int width = 45;
        const int height = 30;
        SimulationManager simulationManager;

        List<MultipleResult> multipleResults;


        bool finished = false;
        bool IsBabyclicked = false;
        bool IsAdultclicked = false;
        bool IsElderclicked = false;
        bool IsFireClicked = false;


        //Timer for the change in labels
        Timer x;
        static int time = 0;
        private static Label timeLabel;
        string textt;
        //  int numPeople = 0;

        double old_time = 0;
        double answer = 0;
        int peeps = 0;
        public List<Results> timeSurv;
        int people_weight = 0;
        int fire_weight = 0;
        static int Total_Num_pple = 0;

        int fire_time = 0;

        List<int> exitcount;

        int peopleBoxCounter = 0;
        int fireBoxCounter = 0;

        string surv = "";
        // list to be of fire extinguishers
        List<InjuredResults> finalResults;


        public Simulation()
        {
            InitializeComponent();

            //Simulation Manager
            simulationManager = new SimulationManager(this);
            simulationManager.SetGridSize(width, height);
            simulationManager.AddWalls();
            multipleResults = new List<MultipleResult>();
            progressBar1.Visible = false;
            panelProgresBar.Visible = false;

        }

        //Methods to be invoked

        private void SetText(string text)
        {
            this.labelTimer.Text = text;
        }

        public List<Results> retlist()
        {
            return timeSurv;
        }

        public static int TotalPeeps()
        {
            return Total_Num_pple;
        }

        private void SetSurvived(string text)
        {
            this.labelSurv.Text = text;

            if (peeps != Convert.ToInt32(simulationManager.NumberOfPeople()))
            {

                Results CurTimeSurv = new Results(Convert.ToInt32(answer), Convert.ToInt32(simulationManager.NumberOfPeople()) * people_weight);
                timeSurv.Add(CurTimeSurv);
                peeps = Convert.ToInt32(simulationManager.NumberOfPeople());
            }


            if (simulationManager.isComplete() || answer >= fire_time)
            {
                // invoke stop thread heare
                simulationManager.KillThread();
                x.Dispose();
                string message = "Time taken: " + textt + "\n" + "Num of Survived: " + text + "\n";


                foreach (Results result in timeSurv)
                {
                    message += "Time: " + result.clearedTime.ToString() + " - " + "People: " + result.people.ToString() + "\n";
                }
                //MessageBox.Show(message);

                exitcount = new List<int>();
                exitcount = simulationManager.retEndpointCount();
                for (int i = 0; i < exitcount.Count; i++)
                {
                    exitcount[i] = exitcount[i] * people_weight;
                }


                //Statistics = new StatisticsForm(timeSurv);
                //Statistics.Show();

                pop = new PopUp(timeSurv, answer.ToString(), Total_Num_pple, exitcount);
                pop.Show();
                string timernum = Regex.Replace(labelTimer.Text, "[^0-9.]", "");
                SqliteDataAcess.SaveSimulation(timeSurv, Convert.ToInt32(timernum), Total_Num_pple, exitcount, Convert.ToInt32(AmountOfFire.Value), Convert.ToInt32(NUDIntensity.Value));

            }
        }

        //End of invoke methods

        private void Button4_Click(object sender, EventArgs e)
        {
            int numFire = Convert.ToInt32(AmountOfFire.Value);
            int intensity = Convert.ToInt32(NUDIntensity.Value);
            if (numFire < 5 && intensity < 1)
            {
                string tempwarning = "";
                tempwarning = "Invalid parameters\n --------------\n Minumum values have been set";
                MessageBox.Show(tempwarning);
                AmountOfFire.Value = 5;
                NUDIntensity.Value = 1;
                
            }
            else
            {
                fireBoxCounter++;
                fire_weight = intensity;
                setFireTimer(fire_weight);
                simulationManager.AddFirePictureBox(numFire);
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        public bool peopleBox(int pp, int ff)
        {
            if(pp < 1 || ff < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int numberOfSim = Convert.ToInt32(npdNumberSimulation.Value);
            
            if (numberOfSim == 1)
            {
                if(peopleBox(peopleBoxCounter,fireBoxCounter))
                {
                    //Assign total amount of people
                    simulationManager.reseting(2);
                    Total_Num_pple = Convert.ToInt32(AmountOfPeople.Value) * people_weight;
                    //Timer begin
                    timeSurv = new List<Results>();
                    x = new Timer(1000); //time tick every second
                    x.AutoReset = true;
                    x.Elapsed += new System.Timers.ElapsedEventHandler(secondTick);
                    x.Start();
                    //-----
                    simulationManager.MovePerson();
                    simulationManager.Endpoint_postion_Assigner();
                }
                else
                {
                    string warnMessage = "";
                    warnMessage = "Invalid parameters\n --------------\n Please select the create for minum values";
                    MessageBox.Show(warnMessage);
                }
                
            }
            else if (numberOfSim <= 0)
            {
                MessageBox.Show("Please enter number of simulaton");
            }
            else
            {
                
                if(allParameters(AmountOfPeople.Value,NUDGroupWeight.Value,AmountOfFire.Value, NUDIntensity.Value))
                {
                    if(nudNumExtinguishers.Value <= 0)
                    {
                        string message = "------------------ALERT-------------------\n\nThe number of extinguishers must at least 1\n ._.";
                        MessageBox.Show(message);
                    }
                    else
                    {
                        MultipleSimulation multipleSimulation = null;
                        SimulationManager simManager = null;
                        multipleResults.Clear();
                        progressBar1.Visible = true;
                        panelProgresBar.Visible = true;
                        progressBar.Start();
                        for (int i = 0; i < numberOfSim; i++)
                        {
                            simManager = new SimulationManager(this);
                            simManager.SetGridSize(width, height);
                            simManager.AddWalls();
                            multipleSimulation = new MultipleSimulation(simManager.algorithm, simManager);
                            simManager.GetRandomHumanPosition();
                            multipleSimulation.AddPeople(Convert.ToInt32(AmountOfPeople.Value), Convert.ToInt32(NUDGroupWeight.Value));
                            simManager.GetRandomPosition();
                            multipleSimulation.AddFire(Convert.ToInt32(AmountOfFire.Value), Convert.ToInt32(NUDIntensity.Value));
                            multipleSimulation.GetThePaths();
                            multipleSimulation.ExitCount();

                            

                            int totalPeople = multipleSimulation.GetTotalPeople();
                            double avgTime = multipleSimulation.GetTheAvgTime();
                            int injured = multipleSimulation.CheckIfInjured();
                            int dead = multipleSimulation.GetCasualties();
                            int exit1 = multipleSimulation.exit1;
                            int exit2 = multipleSimulation.exit2;
                            int exit3 = multipleSimulation.exit3;
                            int survived = totalPeople - dead;

                            Fire fire = multipleSimulation.GetLocationMostInjured();
                            Console.WriteLine("Most Injured : X:{0} , Y:{1}", fire.location.X, fire.location.Y);

                            multipleResults.Add(new MultipleResult(totalPeople, survived, avgTime, injured, dead, exit1, exit2, exit3, fire));

                        }

                        foreach (MultipleResult item in multipleResults)
                        {
                            item.ShowResult();
                        }
                    }
                    
                }
                else
                {
                    string preMessage = "";
                    preMessage = "Invalid parameters\n --------------\n Minumum values have been set";
                    MessageBox.Show(preMessage);
                }

                
            }
        }


        //Multiple simulation Field check input methods

        public bool allParameters(decimal pp, decimal pw, decimal ff, decimal fw)
        {
            if(pp < 6)
            {
                AmountOfPeople.Value = 6;
                if(pw >= 1)
                {
                    NUDGroupWeight.Value = pw;
                }
                else
                {
                    NUDGroupWeight.Value = 1;
                }

                if(ff >= 10)
                {
                    AmountOfFire.Value = ff;
                }
                else
                {
                    AmountOfFire.Value = 10;
                }

                if(fw >= 1)
                {
                    NUDIntensity.Value = fw;
                }
                else
                {
                    NUDIntensity.Value = 10;
                }

                return false;
                
            }
            else if(pw < 1)
            {
                
                NUDGroupWeight.Value = 1;

                if(pp > 5)
                {
                    AmountOfPeople.Value = pp;
                }
                else
                {
                    AmountOfPeople.Value = 6;
                }
                if (ff >= 10)
                {
                    AmountOfFire.Value = ff;
                }
                else
                {
                    AmountOfFire.Value = 10;
                }

                if (fw >= 1)
                {
                    NUDIntensity.Value = fw;
                }
                else
                {
                    NUDIntensity.Value = 10;
                }
                return false;
               
            }
            else if(ff < 10)
            {
                AmountOfFire.Value = 10;
                if (pp > 5)
                {
                    AmountOfPeople.Value = pp;
                }
                else
                {
                    AmountOfPeople.Value = 6;
                }
                if (pw >= 1)
                {
                    NUDGroupWeight.Value = pw;
                }
                else
                {
                    NUDGroupWeight.Value = 1;
                }
                if (fw >= 1)
                {
                    NUDIntensity.Value = fw;
                }
                else
                {
                    NUDIntensity.Value = 10;
                }
                return false;
                
            }
            else if(fw < 1)
            {
                NUDIntensity.Value = 10;
                if (pp > 5)
                {
                    AmountOfPeople.Value = pp;
                }
                else
                {
                    AmountOfPeople.Value = 6;
                }
                if (pw >= 1)
                {
                    NUDGroupWeight.Value = pw;
                }
                else
                {
                    NUDGroupWeight.Value = 1;
                }
                if (ff >= 10)
                {
                    AmountOfFire.Value = ff;
                }
                else
                {
                    AmountOfFire.Value = 10;
                }
                
                return false;
            }
            else
            {
                return true;
            }
        }
        //public string isC
        public void showMultipleSimulationStatistic()
        {
            
            multipleStatistic multipleSimulationResults = new multipleStatistic(multipleResults);
            multipleSimulationResults.set_extinguisher_count(Convert.ToInt32(nudNumExtinguishers.Value));
            multipleSimulationResults.FindExtinquisher();
            multipleSimulationResults.StartPosition = FormStartPosition.Manual;
            finalResults = new List<InjuredResults>();
            finalResults = multipleSimulationResults.returnExtinquishers();
            simulationManager.addExtinquisherPictureBox(finalResults);
            multipleSimulationResults.Show();
        }
        //Timer Methods
        public void secondTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            time += 1000;
            answer = time / 1000;
            textt = answer.ToString() + " Minutes";
            if (this.labelTimer.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { textt });
            }

            surv = (Convert.ToInt32(simulationManager.NumberOfPeople()) * people_weight).ToString();
            if (this.labelSurv.InvokeRequired)
            {
                SetTextCallback c = new SetTextCallback(SetSurvived);
                this.Invoke(c, new object[] { surv });
            }
            //timeLabel.Text = answer.ToString() + "s";
            Console.WriteLine(answer.ToString() + "s");
        }


        private void Timer1_Tick(object sender, EventArgs e)
        { 
            
        }


        private void Button6_Click(object sender, EventArgs e)
        {
            IsBabyclicked = true;
            IsAdultclicked = false;
            IsElderclicked = false;
            IsFireClicked = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (IsBabyclicked)
            {
                Bitmap bmp = new Bitmap(new Bitmap("C:\\Users\\imran\\Desktop\\babys_room_50px.png"));
                this.Cursor = new Cursor(bmp.GetHicon());
            }
            else if(IsAdultclicked)
            {
                Bitmap bmp2 = new Bitmap(new Bitmap("C:\\Users\\imran\\Desktop\\person_male_50px.png"));
                this.Cursor = new Cursor(bmp2.GetHicon());
            }
            else
            {
                Bitmap bmp3 = new Bitmap(new Bitmap("C:\\Users\\imran\\Desktop\\old_man_skin_type_4_50px.png"));
                this.Cursor = new Cursor(bmp3.GetHicon());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IsBabyclicked = false;
            IsAdultclicked = true;
            IsElderclicked = false;
            IsFireClicked = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            IsBabyclicked = false;
            IsAdultclicked = false;
            IsElderclicked = true;
            IsFireClicked = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (IsFireClicked)
            {
                Bitmap bmp4 = new Bitmap(new Bitmap("C:\\Users\\imran\\Desktop\\fire_element_48px.png"));
                this.Cursor = new Cursor(bmp4.GetHicon());
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            IsBabyclicked = false;
            IsAdultclicked = false;
            IsElderclicked = false;
            IsFireClicked = true;
        }

        private void Lblcoordinates_Click(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
          
           
        }

        private void BttnStatistics_Click(object sender, EventArgs e)
        {
            Statistics = new StatisticsForm(timeSurv, labelTimer.Text, Total_Num_pple,exitcount);
            Statistics.Show();
        }

        private void Simulation_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            for (int widthTrav = 15; widthTrav < width; widthTrav++)
            {
                for (int heightTrav = 0; heightTrav < height; heightTrav++)
                {
                    GridBox temp = simulationManager.m_rectangles[widthTrav][heightTrav];
                    graphics.FillRectangle(temp.brush, temp.boxRec);
                }
            }

            for (int widthTrav = 15; widthTrav < width; widthTrav++)
            {
                for (int heightTrav = 0; heightTrav < height; heightTrav++)
                {
                    GridBox temp = simulationManager.m_rectangles[widthTrav][heightTrav];
                    graphics.FillRectangle(temp.brush, temp.boxRec);

                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        { 
            int numPeople = Convert.ToInt32(AmountOfPeople.Value);
            int weightPeople = Convert.ToInt32(NUDGroupWeight.Value);
            if (numPeople < 5 || weightPeople < 1)
            {
                string tempwarning = "";
                tempwarning = "Invalid parameters\n --------------\n Minumum values have been set";
                MessageBox.Show(tempwarning);
                AmountOfPeople.Value = 5;
                NUDGroupWeight.Value = 1;
                
            }
            else
            {
                people_weight = weightPeople;
                peopleBoxCounter++;
                simulationManager.AddHumanPictureBox(numPeople);
            }
        }

        public bool setFireTimer(int frate)
        {
            if(frate == 0)
            {
                fire_time = 120;
                return true;
            }
            else if(frate >= 1 && frate < 35)
            {
                fire_time = 30;
                return true;
            }
            else if(frate >= 35 && frate < 75)
            {
                fire_time = 15;
                return true;
            }
            else if(frate >= 75)
            {
                fire_time = 7;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if(x != null)
            {
                x.Dispose();
            }

            simulationManager.reseting(1);
            simulationManager.KillThread();
            simulationManager.RemoveAllPictureBox();
            time = 0;
            answer = 0;
            Total_Num_pple = 0;
            peeps = 0;
            surv = "0";

            if(timeSurv != null)
            {
                timeSurv.Clear();
            }
            
            
            

            //Simulation aloha = new Simulation();
            //aloha.Show();


        }

        private void AmountOfPeople_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            if (progressBar1.Value >= 100)
            {
                progressBar1.Visible = false;
                panelProgresBar.Visible = false;
                progressBar1.Value = 0;
                showMultipleSimulationStatistic();
                progressBar.Stop();
            }
        }

        private void BttnBack_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms["Form1"];
            form1.BringToFront();
        }

        private void BttnFront_Click(object sender, EventArgs e)
        {
            Form form3 = Application.OpenForms["PopUp"];
            try
            {
                form3.BringToFront();
            }
            catch(Exception)
            {
            }
        }
    }
}

