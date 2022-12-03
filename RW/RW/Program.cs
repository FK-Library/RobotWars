using RW;

Console.WriteLine("Welcome To RobotWars");
Console.WriteLine("Please enter arena grid separating with space (e.g: 5 5) ");
var robotDto = new RobotDTO();
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

//TODO: handleNullString
//TODO:Invalid input Check and error handeling

