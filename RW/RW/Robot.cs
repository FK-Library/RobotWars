using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Heading Heading { get; set; }

        public Robot()
        {

        }
        public Robot(int x, int y, Heading heading) {
            this.X = x;
            this.Y = y;
            this.Heading= heading;
        }


    }
}
