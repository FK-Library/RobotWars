using RW;

namespace RWTest
{
    [TestClass]
    public class RobotWarTests
    {
         

        /**
         * Below test case is for testing usecases:
         */
        [TestMethod]
        [DataRow(5, 5, 1,2,Heading.N, Movement.L)]
        public void MoveRobot_GivenRobotPositionAndDirectionAndNextMovementIsNotM_ReturnsRobotNewPositionAndDirection(
            int maxGridX,
            int maxGridY,
            int robotPositionX,
            int robotPositionY,
            Heading robotHeading,
            Movement robotNextMove)
        {
            //Arrange
            List<Tuple<Heading, Movement, Heading>> list = DirectionFactory();

            var movementCalculator = new MovementCalculator(maxGridX, maxGridY, list);
            var robot = new Robot(robotPositionX, robotPositionY, robotHeading);

            var result = movementCalculator.MoveRobot(robot, robotNextMove);

            Assert.AreEqual(1, result.X);
            Assert.AreEqual(2, result.Y);
            Assert.AreEqual(Heading.W, result.Heading);

        }

        [TestMethod]
        [DataRow(5, 5, 1, 2, Heading.N, Movement.M)]
        public void MoveRobot_GivenRobotPositionAndDirectionAndNextMovementIsM_ReturnsRobotNewPositionAndDirection(
            int maxGridX,
            int maxGridY,
            int robotPositionX,
            int robotPositionY,
            Heading robotHeading,
            Movement robotNextMove)
        {
            //Arrange
            List<Tuple<Heading, Movement, Heading>> list = DirectionFactory();

            var movementCalculator = new MovementCalculator(maxGridX, maxGridY, list);
            var robot = new Robot(robotPositionX, robotPositionY, robotHeading);

            //Act
            var result = movementCalculator.MoveRobot(robot, robotNextMove);

            //Assert
            Assert.AreEqual(1, result.X);
            Assert.AreEqual(3, result.Y);
            Assert.AreEqual(Heading.N, result.Heading);

        }

        private static List<Tuple<Heading, Movement, Heading>> DirectionFactory()
        {
            return new List<Tuple<Heading, Movement, Heading>>()
            {
                new Tuple<Heading, Movement, Heading>(Heading.N, Movement.L, Heading.W),
                   new Tuple<Heading, Movement, Heading> (Heading.N, Movement.R, Heading.E),
                   new Tuple<Heading, Movement, Heading> (Heading.W, Movement.L, Heading.S),
                   new Tuple<Heading, Movement, Heading> (Heading.W, Movement.R, Heading.N),
                   new Tuple<Heading, Movement, Heading> (Heading.S, Movement.L, Heading.E),
                   new Tuple<Heading, Movement, Heading> (Heading.S, Movement.R, Heading.W),
                   new Tuple<Heading, Movement, Heading> (Heading.E, Movement.L, Heading.N),
                   new Tuple<Heading, Movement, Heading> (Heading.E, Movement.R, Heading.S)
            };
        }
    }
}