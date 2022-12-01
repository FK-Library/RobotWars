// See https://aka.ms/new-console-template for more information
using RW;

Console.WriteLine("Welcome To RobotWars");

Console.WriteLine("Please enter area end seperated by space (e.g: 5 5) ");

var readArea = Console.ReadLine();
var areEnd = readArea.Split(' ').ToArray();
Console.WriteLine(areEnd[0], areEnd[1]);

var area = new Area(int.Parse(areEnd[0]), int.Parse(areEnd[1]));



/*
//Should call Robot 1 process and then robot 2- process untill win or fail( they clash or reach boundaries or end)
Console.WriteLine("Please enter 1st robot position");
var p1 = Console.ReadLine();
//Console.WriteLine(p1);
Console.WriteLine("Please enter 1st robot instructions");
var i1 = Console.ReadLine();
//Console.WriteLine(i1);

Console.WriteLine("Please enter 1st robot position");
var p2 = Console.ReadLine();
//Console.WriteLine(p2);
Console.WriteLine("Please enter 1st robot instructions");
var i2 = Console.ReadLine();
//Console.WriteLine(i2);
*/

Console.WriteLine("output of robot 1");
Console.WriteLine("output of robot 2");

var xx = Console.ReadKey();