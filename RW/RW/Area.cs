using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    internal class Area //: IArea
    {
        public Area(int x, int y)
        {
            this.EndX = x;
            this.EndY = y;
        }

        public int EndX;

        public int EndY;

       
    }
}
