using RoyT.AStar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
    public enum AgentType { Start, End, Wall, Normal, Fire, Human };


    public class Agent
    {

        public int Age { get; set; }
        public AgentType AgentType { get; set; }
        public PictureBox PictureBox { get; set; }
        public int GroupMembers { get; set; }
        public int InjuredPeople { get; set; }
        public int DeadPeople { get; set; }
        public bool Dead { get; set; } = false;

        public Position position { get; set; }

        public List<Position[]> paths;
        public Position[] path;

        public Agent(int age, AgentType agentType, PictureBox pixtureBox)
        {
            this.Age = age;
            this.AgentType = agentType;
            this.PictureBox = pixtureBox;
            
        }

        //Multiple Simulation 
        public Agent(int groupMembers, PictureBox pixtureBox)
        {
            this.GroupMembers = groupMembers;
            this.PictureBox = pixtureBox;
            this.position = new Position(pixtureBox.Location.X / 20, (pixtureBox.Location.Y - 50) / 20);
            this.paths = new List<Position[]>();
        }

        public void GetInjured() 
        {
            if (InjuredPeople >= GroupMembers)
            {
                return;
            }
            else
            {
                InjuredPeople = Convert.ToInt32(GroupMembers * 0.20);
            }
        }

        public void GetDead() 
        {
            DeadPeople = GroupMembers;
        }
    }
}
