using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public class MovementCalculator
    {
        public int MaxGridX { get; set; }
        public int MaxGridY { get; set; }

        public List< Tuple<Heading,Movement,Heading>> HeadingMovementMap { get; set; }

        public MovementCalculator(int maxGridX, int maxGridY, List<Tuple<Heading, Movement, Heading>> headingMovementMap ) {
            MaxGridX = maxGridX;
            MaxGridY= maxGridY;
            HeadingMovementMap = headingMovementMap;
        }

        public Heading CalculateNewHeading (Heading current,Movement movement) {

            foreach (var item in HeadingMovementMap)
            {

                if (item.Item1 == current && item.Item2 == (Movement)Enum.Parse(typeof(Movement),movement.ToString()))
                {
                    return item.Item3;
                }

            }

            // If invalid movement return current heading
            return current;
        }


        public Tuple<int, int> GetPositionDelta(Heading heading)
        {
            if (heading == Heading.N)
            {
                return new Tuple<int, int>(0, 1);
            }
            else if (heading == Heading.S)
            {
                return new Tuple<int, int>(0, -1);
            }
            else if (heading == Heading.W)
            {
                return new Tuple<int, int>(-1, 0);
            }
            else
            {
                return new Tuple<int, int>(1, 0);
            }
        }

        public Robot MoveRobot(Robot robot,Movement movement)
        {
            var newHeading = robot.Heading;
            var newX = robot.X;
            var newY = robot.Y;

            if ( (Movement)movement ==Movement.M)
            {
                var delta = this.GetPositionDelta(robot.Heading);
                newX = Math.Min(Math.Max(0, robot.X + delta.Item1), this.MaxGridX);
                newY = Math.Min(Math.Max(0, robot.Y + delta.Item2), this.MaxGridY);
            }
            else
            {
                newHeading = this.CalculateNewHeading(current: robot.Heading, movement:(Movement) movement);
            }

            return new Robot(newX,newY,newHeading);
        }

    }
}
