﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public class RobotDTO : IRobotDTO
    {
        public int EndGridX { get; set; }
        public int EndGridY { get; set; }

        public string Robot1Position { get; set; }
        public string Robot1Direction{ get; set; }
        public string Robot2Position { get; set; }
        public string Robot2Direction { get; set; }


        public void SetGrid(string grid)
        {
            var gridArray = grid.Split(' ').ToArray();
            this.EndGridX = int.Parse(gridArray[0]);
            this.EndGridY = int.Parse(gridArray[1]);
        }

        public void CheckGrid(int fromX, int fromY)
        {

            if (fromX > EndGridX || fromX < 0 || fromY > EndGridY || fromY < 0)
                throw new IndexOutOfRangeException();

        }
    }
}