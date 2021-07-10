using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoyT.AStar;

namespace FireSimulation
{
    public class AlgorithmPathFinding
    {

        private Grid grid;

        public AlgorithmPathFinding(int width, int hight)
        {
            grid = new Grid(width, hight, 1.0f);
            
        }

        public void AddWalls(Position position) 
        {
            grid.BlockCell(position);
        }

        public Position[] GetPath(Position start, Position end, List<Agent> otherHumans)
        {
            foreach (Agent human in otherHumans)
            {
                AddWalls(new Position(human.PictureBox.Location.X / 20, (human.PictureBox.Location.Y - 50) / 20));
            }
            return grid.GetPath(start, end);
        }

        public Position[] GetPath(Position start, Position end) 
        {
            return grid.GetPath(start, end);
        }
    }
}
