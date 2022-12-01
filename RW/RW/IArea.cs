using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    internal interface IArea
    {
        //int StartX { get; set; }
        //int StartY { get; set; }
        int EndX(); 
        int EndY(); 
    }
}
