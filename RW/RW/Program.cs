// See https://aka.ms/new-console-template for more information
using RW;

Console.WriteLine("Welcome To RobotWars");
Console.WriteLine("The game will");

Console.WriteLine("Please enter arena grid separating with space (e.g: 5 5) ");

var grid = Console.ReadLine();
var play = new Play();
play.SetGrid(grid);

Console.WriteLine("Please enter 1st robot position");
var position = Console.ReadLine();

Console.WriteLine("Please enter 1st robot instructions");
var direction = Console.ReadLine();

Console.WriteLine("Robot1 is in this location:");
Console.WriteLine(play.CalculateLocation(location: position, movement: direction));


Console.WriteLine("Please enter 2nd robot position");
 position = Console.ReadLine();

Console.WriteLine("Please enter 2nd robot instructions");
 direction = Console.ReadLine();

Console.WriteLine("Robot2 is in this location:");
Console.WriteLine(play.CalculateLocation(location: position, movement: direction));



var exit = Console.ReadKey();

//TODO: Add GridCheck
//TODO:Call 1st and second player
//TODO:LowercaseCheck
//TODO:Invalid input Check and error handeling

