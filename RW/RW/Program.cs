using RW;

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
        rob = movementCalc.MoveRobot(rob , movement);
        Console.WriteLine($"Robot Finish: {rob.X} {rob.Y} {rob.Heading}");
    }
    Console.WriteLine("\n ------------ \n");
}


