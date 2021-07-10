using RoyT.AStar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
    public class MultipleSimulation
    {      
        public List<Agent> GroupPeoples { get; set; }
        public List<Fire> Fires;


        public List<Fire> PeopleGetInjured;

        private AlgorithmPathFinding algorithm;
        private SimulationManager simulationManager;
        //  public Position[] Paths { get; set; }

        public int exit1 = 0;
        public int exit2 = 0;
        public int exit3 = 0;


        static Random rnd = new Random();

        public MultipleSimulation(AlgorithmPathFinding algorithm, SimulationManager simulationManager)
        {
            this.algorithm = algorithm;

            this.simulationManager = simulationManager;
            this.GroupPeoples = new List<Agent>();
            this.Fires = new List<Fire>();
            this.PeopleGetInjured = new List<Fire>();

        }


        public void AddPeople(int numOfGoups, int numOfPeople) 
        {
            for (int i = 0; i < numOfGoups; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = simulationManager.freeSpaces[rnd.Next(0, simulationManager.freeSpaces.Count)];
                GroupPeoples.Add(new Agent(numOfPeople, pictureBox));
            }
        }

        public void AddFire(int amount, int intensity) 
        {
            for (int i = 0; i < amount; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = simulationManager.freeSpaces[rnd.Next(0, simulationManager.freeSpaces.Count)];
                Fire newFire = new Fire(intensity, pictureBox);
                Fires.Add(newFire);
                algorithm.AddWalls(newFire.location);
            }
        }



        public void GetThePaths() 
        {
            List<Position> exits = simulationManager.GetExistPossitons();
            List<Position[]> paths = new List<Position[]>();

            foreach (Agent people in GroupPeoples)
            {
                foreach (Position exit in exits)
                {
                    paths.Add(algorithm.GetPath(people.position, exit));
                    //people.paths.Add(); 
                }
                paths = paths.FindAll(p => p.Length > 0).OrderBy(p => p.Length).ToList();

                if (paths.Count == 0)
                {
                    people.DeadPeople = people.GroupMembers;
                    people.Dead = true;
                }
                else
                {
                    people.path = paths.First();
                    paths.Clear();
                }  
            }
        }


        public double GetTheAvgTime()
        {
            double time = 0;
            double numOfPeople = GroupPeoples.Count();

            foreach (Agent person in GroupPeoples)
            {
                if (person.Dead == true)
                    time += 0;
                else
                    time += person.path.Count(); 
            }
            return (time * 60) / numOfPeople;
        }


        public int CheckIfInjured() 
        {
            int injured = 0;
            foreach (Agent agent in GroupPeoples)
            {
                CheckFire(agent);
                //Console.WriteLine(" Injured People:  {0}", agent.InjuredPeople);
                injured += agent.InjuredPeople;
            }

            return injured;
        }


        public void CheckFire(Agent agent) 
        {
            Position[] positions = agent.path;

            if (agent.Dead == true)
            {
                return;
            }
            else 
            { 
                foreach (Position pos in positions)
                {
                    foreach (Fire fire in Fires)
                    {
                        // UP
                        if (pos.X == fire.location.X && pos.Y - 1 == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;
                            
                        }
                        // Down
                        else if (pos.X == fire.location.X && pos.Y + 1 == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;      
                        }
                        //Right
                        else if (pos.X+1 == fire.location.X && pos.Y  == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;
                        }
                        // Left
                        else if (pos.X - 1 == fire.location.X && pos.Y == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;
                        }
                        // Top Right
                        else if(pos.X + 1 == fire.location.X && pos.Y -1 == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;
                        }
                        // Top Left
                        else if (pos.X - 1 == fire.location.X && pos.Y - 1 == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;
                        }
                        // Bottom Left
                        else if (pos.X - 1 == fire.location.X && pos.Y + 1 == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;
                        }
                        // Bottom Right
                        else if (pos.X + 1 == fire.location.X && pos.Y + 1 == fire.location.Y)
                        {
                            GetInjured(fire, agent);
                            fire.injured++;
                        }
                    }
                }
            }
        }

        public Fire GetLocationMostInjured() 
        {
            Fire fire = Fires.OrderByDescending(i => i.injured).First();

            return fire;
        }

        public void GetInjured(Fire fire, Agent agent) 
        {
            int injured = agent.InjuredPeople += (agent.GroupMembers * fire.Intensity) / 100;

            if (injured >= agent.GroupMembers)
            {
                agent.InjuredPeople = agent.GroupMembers;
            }
            else 
            { 
                agent.InjuredPeople += (agent.GroupMembers * fire.Intensity) /  100;
            }
        }


        public void ExitCount() 
        {
            simulationManager.Endpoint_postion_Assigner();

            foreach (Agent item in GroupPeoples)
            {
                if (item.path == null)
                {
                    item.Dead = true;
                }
                else 
                {
                    Position endpoint = item.path.Last();
                    if (endpoint.X == simulationManager.endpoints[0].X && endpoint.Y == simulationManager.endpoints[0].Y)
                    {
                        exit1 += item.GroupMembers;
                       
                    }
                    else if (endpoint.X == simulationManager.endpoints[1].X && endpoint.Y == simulationManager.endpoints[1].Y)
                    {
                        exit2 += item.GroupMembers;

                    }
                    else if (endpoint.X == simulationManager.endpoints[2].X && endpoint.Y == simulationManager.endpoints[2].Y)
                    {
                        exit3 += item.GroupMembers;
                    }
       
                }
            }
        }

        public void ShowExit() 
        {
            Console.WriteLine("Exit 1 {0}", exit1);
            Console.WriteLine("Exit 2 {0}", exit2);
            Console.WriteLine("Exit 3 {0}", exit3);
        }


        public int GetCasualties() 
        {
            int dead = 0;

            foreach (Agent person in GroupPeoples)
            {
                if (person.Dead.Equals(true))
                {
                    person.GetDead();
                    dead += person.GroupMembers;
                }
            }
            return dead;
        }


        public int GetTotalPeople() 
        {
            int people = 0;
            foreach (Agent peoples in GroupPeoples)
            {
                people += peoples.GroupMembers;
            }

            return people;
        }

        public void GetFire()
        {
            Console.WriteLine("Fire Location");
            foreach (Fire item in Fires)
            {
                Console.WriteLine("X: {0}, Y:{1}", item.location.X, item.location.Y);
            }
        }

        public void GetPeople()
        {
            Console.WriteLine("People Location");
            foreach (Agent item in GroupPeoples)
            {
                Console.WriteLine("X: {0}, Y:{1}", item.position.X, item.position.Y);
            }
        }

    }
}
