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
        [DataRow("5 5","1 2 N","LMLMLMLMM" ,"1 3 N")]
        [DataRow("5 5", "3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void Play_GivenGridAndPositionAndDrirection_ReturnsRobotFinalPosition (string grid, string position,string direction,string expected)
        {
            var robotDto = new RobotDTO();
            var gridInput = Console.ReadLine();
            robotDto.SetGrid(gridInput);
            var play = new Play(robotDto);

            var result = play.CalculateLocation(location:position, movement:direction);

            Assert.AreEqual(expected, result);

        }
    }
}