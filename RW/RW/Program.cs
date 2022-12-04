using RW;
using System.Collections.Generic;

var inputService = new InputService();
var details = inputService.CollectDetails();
var list = new List<Tuple<Heading, Movement, Heading>>()
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



var movementCalc = new MovementCalculator(details.MaxGridX, details.MaxGridY, list);

foreach (var detail in details.RobotInstructions)
{
    var rob = detail.Robot;

    Console.WriteLine($"Robot Start: {detail.Robot.X} {detail.Robot.Y} {detail.Robot.Heading}");
    foreach (var movement in detail.Instructions)
    {

        rob =
           movementCalc.MoveRobot(rob , movement);

        Console.WriteLine($"Robot Finish: {rob.X} {rob.Y} {rob.Heading}");

    }
    Console.WriteLine("\n ------------ \n");
}

/*
Console.WriteLine("Welcome To RobotWars");
Console.WriteLine("Please enter arena grid separating with space (e.g: 5 5) ");
var robotDto = new Grid();
var gridInput = Console.ReadLine();
robotDto.SetGrid(gridInput);
var play = new Play(robotDto);


    Console.WriteLine("Please enter 1st robot position");
    robotDto.Robot1Position = Console.ReadLine();

    Console.WriteLine("Please enter 1st robot instructions");
    robotDto.Robot1Direction = Console.ReadLine();


    Console.WriteLine("Please enter 2nd robot position");
    robotDto.Robot2Position = Console.ReadLine();

    Console.WriteLine("Please enter 2nd robot instructions");
    robotDto.Robot2Direction = Console.ReadLine();

    Console.WriteLine("Robot1 is in this location:");
    Console.WriteLine(play.CalculateLocation(location: robotDto.Robot1Position, movement: robotDto.Robot1Direction));
    Console.WriteLine("\n---------------------------\n");


    Console.WriteLine("Robot2 is in this location:");
    Console.WriteLine(play.CalculateLocation(location: robotDto.Robot2Position, movement: robotDto.Robot2Direction));
    Console.WriteLine("\n---------------------------\n");
*/
//TODO: handleNullString
//TODO:Invalid input Check and error handeling

