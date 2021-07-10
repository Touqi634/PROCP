using RoyT.AStar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
    public class SimulationManager
    {
        List<GridBox> gridBoxes;
        List<Agent> fires;
        public List<Agent> humans;
        public List<Agent> fireRemove;
        public GridBox[][] m_rectangles;
        public int survived = 0;
        GridBox[][] m_person;
        PictureBox currentHumanBox;
        Agent currentperson;
        Form form;
        static int pictureBoxID = 0;
        static int fireBoxID = 0;
        public AlgorithmPathFinding algorithm;
        public  List<Point> freeSpaces;
        public  List<Point> humanSpaces;
        Random rnd = new Random();

       public  List<Position> endpoints;

        public  int exit1 = 0;
        public  int exit2 = 0;
        public  int exit3 = 0;

        bool reseted = false;


        int Num_of_people = 0;

        List<int> endpointcount;
        public SimulationManager(Form form)
        {
            this.form = form;
        }

        public SimulationManager()
        {

        }

        public void SetGridSize(int width, int height)
        {
            AddGrid(width, height);
            algorithm = new AlgorithmPathFinding(width, height);
        }


        public void AddGrid(int width, int height)
        {

            gridBoxes = new List<GridBox>();
            //humans picture boxes
            humans = new List<Agent>();
            //
            //form.DoubleBuffered = true;
            form.Width = (width + 1) * 20 + 50;
            form.Height = (height + 1) * 20 + 100;
            form.MaximumSize = new Size(form.Width, form.Height);
            form.MaximizeBox = false;
            form.BackColor = Color.RosyBrown;

            m_person = new GridBox[width][];
            m_rectangles = new GridBox[width][];


            for (int widthTrav = 0; widthTrav < width; widthTrav++)
            {
                m_rectangles[widthTrav] = new GridBox[height];
                for (int heightTrav = 0; heightTrav < height; heightTrav++)
                {
                    //if (widthTrav == 20 && heightTrav == 17)
                    //m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Start);
                    if (widthTrav == 40 && heightTrav == 15)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.End);
                    else if (widthTrav < width - 1 && widthTrav > 15 && heightTrav == 1)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (widthTrav < width - 1 && widthTrav > 15 && heightTrav == 28)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (((widthTrav < 23 && widthTrav > 15) ||
                              (widthTrav < 44 && widthTrav > 31) ||
                              (widthTrav < 31 && widthTrav > 23)) && heightTrav == 7)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (((widthTrav < 22 && widthTrav > 15) ||
                             (widthTrav < 31 && widthTrav > 24)) && heightTrav == 10)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (((widthTrav < 22 && widthTrav > 15) ||
                             (widthTrav < 31 && widthTrav > 24)) && heightTrav == 20)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (((widthTrav < 23 && widthTrav > 15) ||
                            (widthTrav < 44 && widthTrav > 31) ||
                            (widthTrav < 31 && widthTrav > 23)) && heightTrav == 23)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (widthTrav == 16 &&
                        (heightTrav > 1 && heightTrav < 29))
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (widthTrav == 22 &&
                        ((heightTrav >= 10 && heightTrav < 14) ||
                         (heightTrav > 16 && heightTrav <= 20)))
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (widthTrav == 25 &&
                        ((heightTrav >= 10 && heightTrav < 14) ||
                         (heightTrav > 16 && heightTrav <= 20)))
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (widthTrav == 28 &&
                       ((heightTrav > 1 && heightTrav < 7) ||
                        (heightTrav > 23 && heightTrav <= 28)))
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (widthTrav == 30 &&
                       ((heightTrav > 10 && heightTrav < 20)))
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    else if (widthTrav == 43 &&
                       (heightTrav > 1 && heightTrav < 29))
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Wall);
                    //Draw Human grid

                    else if (widthTrav == 40 && heightTrav == 27)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.End);
                    else if (widthTrav == 40 && heightTrav == 3)
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.End);
                    else
                    {
                        m_rectangles[widthTrav][heightTrav] = new GridBox(widthTrav * 20, heightTrav * 20 + 50, BoxType.Normal);
                    }
                    gridBoxes.Add(m_rectangles[widthTrav][heightTrav]);
                }
            }
            currentperson = null;
        }

        public List<Point> GetAvailablePositionFor(int amount_human)
        {
            List<Point> freePoints = new List<Point>();
            List<Point> points = new List<Point>()
            {
                new Point(-1,-1),new Point(0,-1),new Point(1,-1),new Point(-1,0),
                new Point(1,0),new Point(-1,1),new Point(0,1),new Point(1,1)
            };
            //assume we have only one start point 
            GridBox startBox = GetGridBoxes(BoxType.Start)[0];
            Point startPoint = new Point(startBox.x, startBox.y);
            foreach (Point p in points)
            {
                Point freePoint = new Point(p.X * 20 + startPoint.X, p.Y * 20 + startPoint.Y);
                freePoints.Add(freePoint);
            }

            return freePoints;
        }

        public void GetRandomPosition()
        {

            freeSpaces = new List<Point>();
            foreach (GridBox grid in gridBoxes)
            {
                if (grid.boxType == BoxType.Normal && grid.x > 320 && grid.x < 880 && grid.y > 90 && grid.y < 580)
                {
                    Point CurPoint = new Point(grid.x, grid.y);
                    freeSpaces.Add(CurPoint);
                }
            }
        }

        //Get random human position
        public void GetRandomHumanPosition()
        {

            freeSpaces = new List<Point>();
            humanSpaces = new List<Point>();
            foreach (GridBox grid in gridBoxes)
            {
                if (grid.boxType == BoxType.Normal && grid.x > 320 && grid.x < 880 && grid.y > 90 && grid.y < 580)
                {
                    Point CurPoint = new Point(grid.x, grid.y);
                    freeSpaces.Add(CurPoint);
                    humanSpaces.Add(CurPoint);
                }
            }
        }

        public void AddHumanPictureBox(int amount)
        {
            GetRandomHumanPosition();
            //List<Point> points = GetAvailablePositionFor(amount);  //change getavailable method to get available point
            for (int i = 0; i < amount; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "humanPbx" + pictureBoxID++;
                pictureBox.Size = new Size(20, 20);
                pictureBox.BackColor = Color.HotPink;
                pictureBox.Location = freeSpaces[rnd.Next(0, freeSpaces.Count)];
                pictureBox.MouseClick += new MouseEventHandler((o, e) =>
                {
                    currentperson = humans.Find(item => item.PictureBox == pictureBox);
                });

                Agent agent = new Agent(20, AgentType.Human, pictureBox);

                form.Controls.Add(agent.PictureBox);   //Add picturebox to form
                humans.Add(agent); //add agent type human to list humans
            }
        }

        
        public void AddFirePictureBox(int amount)
        {
            GetRandomPosition();
            for (int i = 0; i < amount; i++)
            {
                PictureBox fireBox = new PictureBox();
                fireBox.Name = "firebx" + fireBoxID++;
                fireBox.Size = new Size(20, 20);
                fireBox.BackColor = Color.Goldenrod;

                //fireBox.Location is randomly generated
                fireBox.Location = freeSpaces[rnd.Next(0, freeSpaces.Count)]; ;
                Agent agent = new Agent(0, AgentType.Fire, fireBox);
                Console.WriteLine(fireBox.Location);

                form.Controls.Add(agent.PictureBox);
                humans.Add(agent);
            }
        }


        public void addExtinquisherPictureBox(List<InjuredResults> res)
        {
            fireRemove = new List<Agent>();
            int extID = 0;
            foreach (var result in res)
            {
                PictureBox extinBox = new PictureBox();
                extinBox.Name = "ExtinBox" + extID++;
                extinBox.Size = new Size(20, 20);
                extinBox.BackColor = Color.Aqua;

                extinBox.Location = new Point((result.flame.location.X*20), (result.flame.location.Y*20+50));
                Agent agent = new Agent(0, AgentType.Fire, extinBox);
                Console.WriteLine(extinBox.Location);

                form.Controls.Add(agent.PictureBox);
                fireRemove.Add(agent);

               
            }
        }
        public void RemoveAllPictureBox() //delete all picturebox
        {
            if(humans != null)
            {
                foreach (Agent a in humans)
                {
                    form.Controls.Remove(a.PictureBox);

                }
                humans.Clear();
            }
            

            if(fires != null)
            {
                foreach (Agent a in fires)
                {
                    form.Controls.Remove(a.PictureBox);
                }
                fires.Clear();
            }
            

            if(fireRemove != null)
            {
                foreach (Agent b in fireRemove)
                {
                    form.Controls.Remove(b.PictureBox);
                }
                fireRemove.Clear();
            }

            exit1 = 0;
            exit2 = 0;
            exit3 = 0;
            survived = 0;
            fireBoxID = 0;
            Num_of_people = 0;
            pictureBoxID = 0;
            
           
            
            form.Refresh();

        }

        public void reseting(int num)
        {
            if(num == 1)
            {
                reseted = true;
            }
            else
            {
                reseted = false; 
            }
        }
        public List<GridBox> GetGridBoxes(BoxType boxtype)
        {
            List<GridBox> boxes = new List<GridBox>();
            foreach (GridBox grid in gridBoxes)
            {
                if (grid.boxType == boxtype)
                    boxes.Add(grid);
            }
            return boxes;
        }

        public void AddWalls()
        {
            foreach (GridBox item in gridBoxes)
            {
                if (item.boxType == BoxType.Wall)
                {
                    algorithm.AddWalls(new Position(item.x / 20, (item.y - 50) / 20));
                    //Console.WriteLine("{0} {1}", item.x / 20, (item.y - 50) / 20);
                }
            }
        }
        Boolean stopThread = false;
        public void KillThread()
        {
            stopThread = true;
        }
        public void MovePerson()
        {
            GridBox endPoint = GetGridBoxes(BoxType.End)[0]; //first endpoint/exit of the list
            stopThread = false;
            lock (humans)
            {
                foreach (Agent person in humans)
                {
                    Thread th = new Thread(() =>
                    {
                        if (person.AgentType == AgentType.Human)
                        {
                            Position start = new Position(person.PictureBox.Location.X / 20, (person.PictureBox.Location.Y - 50) / 20);
                            Position end = new Position(endPoint.x / 20, (endPoint.y - 50) / 20);
                            Position[] path = algorithm.GetPath(start, end, humans.FindAll(human => human.PictureBox.Name != person.PictureBox.Name));
                            Position node = new Position();
                            do
                            {
                                if (stopThread)
                                {
                                    break;
                                }
                                path = GetClosestEndPointPath(person, out end);
                                if (path.Length == 1)
                                {
                                    node = path[0];
                                }
                                else
                                {
                                    node = path[1];
                                }
                                start = node;
                                person.PictureBox.Invoke((MethodInvoker)delegate { person.PictureBox.Location = new Point(node.X * 20, node.Y * 20 + 50); });
                                Wait(600);
                            } while (node != end);

                            if(!reseted)
                            {
                                Num_of_people++;

                                endpointCounter(node);
                                if (node == end)
                                {
                                    person.PictureBox.Invoke((MethodInvoker)delegate { person.PictureBox.Visible = false; });
                                }
                            }
                            
                            
                           
                        }
                    });
                    th.Start();
                    survived++;
                }
            }
            fires = humans;
            humans = new List<Agent>();
        }

        private Position[] GetClosestEndPointPath(Agent person, out Position endpoint)
        {

            Position start = new Position(person.PictureBox.Location.X / 20, (person.PictureBox.Location.Y - 50) / 20);
            List<Position[]> paths = new List<Position[]>();
            List<GridBox> endPoints = GetGridBoxes(BoxType.End);
            foreach (GridBox endPoint in endPoints)
            {
                Position end = new Position(endPoint.x / 20, (endPoint.y - 50) / 20);
                Position[] path = algorithm.GetPath(start, end, humans.FindAll(human => human.PictureBox.Name != person.PictureBox.Name));
                paths.Add(path);
            }
            //compare path lengths

            List<Position[]> temp = paths.FindAll(p => p.Length > 0).OrderBy(p => p.Length).ToList();
            if (temp.Count == 0)
            {
                endpoint = new Position(endPoints[0].x / 20, (endPoints[0].y - 50) / 20);
                return new Position[] { start, start };
            }
            Position[] shortestPath = temp[0];
            endpoint = shortestPath[shortestPath.Length - 1];
            return shortestPath;
        }

        public void Wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        //check if the all the people have left the floor
        public bool isComplete()
        {
            List<Agent> beings = new List<Agent>();
            foreach (Agent p in fires)
            {
                if (p.AgentType == AgentType.Human)
                {
                    beings.Add(p);
                }
            }

            if (Num_of_people == beings.Count)
            {
                return true;
            }

            return false;
        }

        public string NumberOfPeople()
        {
            return Num_of_people.ToString();
        }


        public bool endpointCounter(Position endpoint)
        {
            
            if(endpoint.X == endpoints[0].X && endpoint.Y == endpoints[0].Y)
            {
                exit1++;
                return true;
            }
            else if(endpoint.X == endpoints[1].X && endpoint.Y == endpoints[1].Y)
            {
                exit2++;
                return true;
            }
            else if(endpoint.X == endpoints[2].X && endpoint.Y == endpoints[2].Y)
            {
                exit3++;
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Endpoint_postion_Assigner()
        {
            endpoints = new List<Position>();
            foreach (var box in gridBoxes)
            {
                if (box.boxType == BoxType.End)
                {
                    Position curEnd = new Position(box.x / 20, (box.y - 50) / 20);
                    endpoints.Add(curEnd);
                }

            }
        }

        public List<int> retEndpointCount()
        {
            endpointcount = new List<int>();

            endpointcount.Add(exit1);
            endpointcount.Add(exit2);
            endpointcount.Add(exit3);

            return endpointcount;
        }

        public List<Position> GetExistPossitons() 
        {
            List<Position> exits = new List<Position>();

            foreach (GridBox item in gridBoxes)
            {
                if (item.boxType == BoxType.End)
                {
                    exits.Add(new Position(item.x / 20, (item.y - 50) / 20));
                }
            }
            return exits;
        }
    }
}
