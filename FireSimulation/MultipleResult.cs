using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSimulation
{
    public  class MultipleResult
    {

        int totalPeople;
        int totalSurvived;
        double avgTime;
        int injured;
        int dead;
        Fire extin;

        public MultipleResult(int totalPeople, int totalSurvived, double avgTime, int injured,int dead, int exit1 , int exit2, int exit3, Fire extinguish)
        {
            this.totalPeople = totalPeople;
            this.totalSurvived = totalSurvived;
            this.avgTime = avgTime;
            this.injured = injured;
            this.dead = dead;
            this.Exit1 = exit1;
            this.Exit2 = exit2;
            this.Exit3 = exit3;
            this.extin = extinguish;
        }

        public int TotalPeople { get {return totalPeople; } set { totalPeople = value ; } }
        public int TotalSurvived { get { return totalSurvived; } set { totalSurvived = value; } }
        public double AvgTime { get { return avgTime; } set { avgTime = value; } }
        public int Injured { get { return injured; } set { injured = value; } }
        public int Dead { get { return dead; } set { dead = value; } }
        public int Exit1 { get; set; }
        public int Exit2 { get; set; }
        public int Exit3 { get; set; }
        public Fire Extin { get { return extin; } set { extin = value; } }

        public void ShowResult() 
        {
            Console.WriteLine("Total people: {0} " +
                              "Total survived: {1} " +
                              "Avarage time: {2} " +
                              "Injured people: {3} " +
                              "Dead people: {4} " +
                              "Exit1: {5} " +
                              "Exit2: {6} " +
                              "Exit3: {7} "
                              ,TotalPeople,TotalSurvived,AvgTime,Injured,Dead,Exit1,Exit2,Exit3 );
        }
        
    }
}
