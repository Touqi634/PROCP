using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace FireSimulation
{
   public class SqliteDataAcess
    {
        public static void SaveSimulation(List<Results> results, int time, int Total_people, List<int> exitcount, int fire, int fire_intensity)
        {
            string floorplan = "A";
            DateTime now = DateTime.Now;
    
            
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Simulation (People, Survived, Time, Fire, Fire_Intensity, Floor_Plan, Time_Stamp) values ( " + Total_people.ToString() + "," + results[results.Count - 1].people.ToString() + ", " + time.ToString() + ", " + fire.ToString() + ", " + fire_intensity.ToString() + ", '" + floorplan + "', '" + now.ToString() + "')");
                long lastid = (long)cnn.ExecuteScalar("select MAX(id) from Simulation");
                foreach (int exit in exitcount)
                {
                    cnn.Execute("insert into Exit (Sim_ID, Exitors) values (" + lastid + " , " + exit +" )");

                }

                foreach (Results res in results)
                {
                    cnn.Execute("insert into Results (Sim_ID, clearedTime, people) values (" + lastid + " , " + res.clearedTime.ToString() + ", " + res.people.ToString() + " )");

                }
            }

        }

        public static void SaveMultipleSimulation(List<MultipleResult> results, int time, int Total_people, List<int> exitcount, int fire, int fire_intensity)
        {
            string floorplan = "A";
            DateTime now = DateTime.Now;


            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Simulation (People, Survived, Time, Fire, Fire_Intensity, Floor_Plan, Time_Stamp) values ( " + Total_people.ToString() + "," + results[results.Count - 1].TotalPeople.ToString() + ", " + time.ToString() + ", " + fire.ToString() + ", " + fire_intensity.ToString() + ", '" + floorplan + "', '" + now.ToString() + "')");
                long lastid = (long)cnn.ExecuteScalar("select MAX(id) from Simulation");
                foreach (int exit in exitcount)
                {
                    cnn.Execute("insert into Exit (Sim_ID, Exitors) values (" + lastid + " , " + exit + " )");

                }

                foreach (MultipleResult res in results)
                {
                    cnn.Execute("insert into Results (Sim_ID, clearedTime, people) values (" + lastid + " , " + res.AvgTime.ToString() + ", " + res.TotalPeople.ToString() + " )");

                }
            }

        }

        public static List<Results> LoadResults(int Sim_ID)
        {
            List<Results> temp = new List<Results>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand comm = new SQLiteCommand("select * from Results where Sim_ID = " + Sim_ID.ToString(), cnn);
                cnn.Open();
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Results resulthandler;

                        int Sim_id = Convert.ToInt32(read.GetValue(0));
                        int clearedTime = Convert.ToInt32(read.GetValue(1));
                        int people = Convert.ToInt32(read.GetValue(2));

                        resulthandler = new Results(clearedTime, people);
                        temp.Add(resulthandler);
                    }
                    return temp;
                }
            }
        }

        public static List<DBExit> LoadDBExit(int Sim_ID)
        {
            List<DBExit> temp = new List<DBExit>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand comm = new SQLiteCommand("select * from Exit where Sim_ID = " + Sim_ID.ToString(), cnn);
                cnn.Open();
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        DBExit exithandler;

                        int id = Convert.ToInt32(read.GetValue(0));
                        int Sim_id = Convert.ToInt32(read.GetValue(1));
                        int Exitors = Convert.ToInt32(read.GetValue(2));

                        exithandler = new DBExit(id, Sim_id, Exitors);

                        temp.Add(exithandler);
                    
                    }
                    return temp;
                }
            }
        }

        public static List<int> LoadExit(int Sim_ID)
        {
            List<int> temp = new List<int>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand comm = new SQLiteCommand("select Exitors from Exit where Sim_ID = " + Sim_ID.ToString(), cnn);
                cnn.Open();
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int exithandler;

                        exithandler = Convert.ToInt32(read.GetValue(0));

                        temp.Add(exithandler);

                    }
                    return temp;
                }
            }
        }

        public static List<DBSimulation> LoadSimulation()
        {
            List<DBSimulation> temp = new List<DBSimulation>();

            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //var output = cnn.Query<DBSimulation>("select * from Simulation", new DynamicParameters());
                //return output.ToList();
                SQLiteCommand comm = new SQLiteCommand("select * from Simulation", cnn);
                cnn.Open();
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        DBSimulation simhandler;

                        int id = Convert.ToInt32(read.GetValue(0));
                        int people = Convert.ToInt32(read.GetValue(1));
                        int survived = Convert.ToInt32(read.GetValue(2));
                        int time = Convert.ToInt32(read.GetValue(3));
                        int fire = Convert.ToInt32(read.GetValue(4));
                        int fire_intensity = Convert.ToInt32(read.GetValue(5));
                        string floor_plan = Convert.ToString(read.GetValue(6));
                        string time_stamp = Convert.ToString(read.GetValue(7));

                        simhandler = new DBSimulation(id, people, survived, time, fire, fire_intensity,floor_plan,time_stamp);

                        temp.Add(simhandler);
                  
                    }
                    return temp;
                }
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
