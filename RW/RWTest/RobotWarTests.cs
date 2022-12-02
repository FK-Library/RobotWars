using RW;

namespace RWTest
{
    [TestClass]
    public class RobotWarTests
    {
        [TestMethod]
        [DataRow("5 5","1 2 N","LMLMLMLMM" ,"1 3 N")]
        public void Play_GivenGridAndPositionAndDrirection_ReturnsRobotFinalPosition (string grid, string position,string direction,string expected)
        {
            var play = new Play();

            var result = play.CalculateLocation(location:position, movement:direction);

            Console.WriteLine(result);

            Assert.AreEqual(expected, result);

        }
    }
}