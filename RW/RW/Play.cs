using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public class Play
    {
        public int EndGridX { get; set; } = 5;
        public int EndGridY { get; set; } = 5;
        public string RobotLocation { get; set; }
        public string RobotMovement { get; set; }

        public Tuple<int, int> Cord = new Tuple<int, int>(0,0);

        public static string Direction(string from,string headTo)
        {
            if (from == "N" && headTo == "L") return  "W";
            if (from == "N" && headTo == "R") return "E";
            if (from == "W" && headTo == "L") return "S";
            if (from == "W" && headTo == "R") return "N";
            if (from == "S" && headTo == "L") return "E";
            if (from == "S" && headTo == "R") return "W";
            if (from == "E" && headTo == "L") return "N";
            if (from == "E" && headTo == "R") return "S";
            return null;
        }

        public static Tuple<int, int> CalculateDirection(int x,int y ,string direction)
        {

            switch (direction.ToUpper())
            {
                case "N":
                    return new Tuple<int, int>(x, y + 1);

                case "W":
                    return new Tuple<int, int> (x-1,y);

                case "S":
                    return new Tuple<int, int>(x, y-1 );
                
                case "E":
                    return new Tuple<int, int>(x+1, y );
            }

            return new Tuple<int, int>(x, y);
        }


        public  string CalculateLocation(string location, string movement)
        {
            var locationArray = location.Split(' ').ToArray();
            var fromX = int.Parse(locationArray[0]);
            var fromY = int.Parse(locationArray[1]);
            var fromDirection = locationArray[2].ToString().ToUpper();

            char[] instructionArray = new char[movement.Length];
            instructionArray = movement.ToCharArray();

            for (int i = 0 ; i < movement.Length; i++)
            {
                if (instructionArray[i].ToString() != "M")
                {
                    fromDirection = Direction(fromDirection, instructionArray[i].ToString());
                }
                
                if(instructionArray[i].ToString() == "M")
                {
                    var newCoordination= CalculateDirection(fromX,fromY,fromDirection);
                    fromX = newCoordination.Item1;
                    fromY = newCoordination.Item2;
                    ValidateCoordination(fromX, fromY);
                }

            }

            return $"{fromX} {fromY} {fromDirection}";

        }

        public void ValidateCoordination(int fromX, int fromY)
        {
            if (fromX > EndGridX || fromX < 0 || fromY > EndGridY|| fromY<0) throw new IndexOutOfRangeException();
           
        }

        //TODO: Add GridCheck
        //TODO:Call 1st and second player
        //TODO:LowercaseCheck
        //TODO:Invalid input Check and error handeling




    }
}
