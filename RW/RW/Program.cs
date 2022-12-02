using RW;

Console.WriteLine("Welcome To RobotWars");
Console.WriteLine("If you want to exit, write EXIT");

Console.WriteLine("Please enter arena grid separating with space (e.g: 5 5) ");

var play = new Play();
var grid = Console.ReadLine();
var player1Position = "";
var player2Position = "";

if (!grid.ToUpper().Equals("EXIT"))
{
    play.SetGrid(grid);

    Console.WriteLine("Please enter 1st robot position");
    var position = Console.ReadLine();

    Console.WriteLine("Please enter 1st robot instructions");
    var direction = Console.ReadLine();

    Console.WriteLine("Robot1 is in this location:");
    player1Position = play.CalculateLocation(location: position, movement: direction);
    Console.WriteLine(player1Position);
    Console.WriteLine("---------------------------");

    Console.WriteLine("Please enter 2nd robot position");
    position = Console.ReadLine();

    Console.WriteLine("Please enter 2nd robot instructions");
    direction = Console.ReadLine();

    Console.WriteLine("Robot2 is in this location:");
    player2Position = play.CalculateLocation(location: position, movement: direction);
    Console.WriteLine(player1Position);
    Console.WriteLine("---------------------------");

}


while (!grid.ToUpper().Equals("EXIT"))
{

    Console.WriteLine("Please enter 1st robot instructions");
    var direction = Console.ReadLine();
    Console.WriteLine("Robot1 is in this location:");
    Console.WriteLine(play.CalculateLocation(location: player1Position, movement: direction));
    Console.WriteLine("---------------------------");

    Console.WriteLine("Please enter 2nd robot instructions");
    direction = Console.ReadLine();
    Console.WriteLine("Robot2 is in this location:");
    Console.WriteLine(play.CalculateLocation(location: player2Position, movement: direction));
    Console.WriteLine("---------------------------");

}

//TODO:Invalid input Check and error handeling

