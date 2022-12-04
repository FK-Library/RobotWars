using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RW
{
    public class InputService
    {
        public InputResults CollectDetails()
        {
            var gridDetails = this.CollectGridDetails();
            var robot1 = this.CollectRobotDetails();
            var robot2 = this.CollectRobotDetails();
            return new InputResults()
            {
                MaxGridX= gridDetails.Item1,
                MaxGridY= gridDetails.Item2,
                RobotInstructions=new List<RobotInstructions> { robot1, robot2 }

            };
        }

        public bool ValidateGridInput(string inputString)
        {
            string pattern = @"^[0-9] [0-9]$";
            return Regex.IsMatch(inputString,pattern, RegexOptions.IgnoreCase);
        }

        public Tuple<int, int> CollectGridDetails()
        {
            var validInput=false;
            string[] gridArray;

            while (!validInput)
            {
                Console.WriteLine("Please enter the grid boundaries: ");
                var input = Console.ReadLine();
                validInput = ValidateGridInput(input);
                if (!validInput) Console.WriteLine("Input was invalid - please try again");

                 gridArray = input.Split(' ').ToArray();
                return new Tuple<int, int>(int.Parse(gridArray[0]), int.Parse(gridArray[1]));
            }
            return new Tuple<int, int>(5, 5); //default to 5,5
        }

        public bool ValidateRobotInput(string inputString)
        {
            string pattern = @"^[0-9] [0-9] [N|E|S|W]$";
            return Regex.IsMatch(inputString, pattern, RegexOptions.IgnoreCase);
        }

        public bool ValidateRobotInstructionsInput(string inputString)
        {
            string pattern = @"^[L|R|M]*$";
            return Regex.IsMatch(inputString, pattern, RegexOptions.IgnoreCase);
        }

        public RobotInstructions CollectRobotDetails()
        {

            var validInput = false;
            int robotX=0;
            int robotY=0;
            Heading robotD=Heading.N;
            
            var instructions = new List<Movement>();
            
            // Robot details collection
            while (!validInput)
            {
                Console.WriteLine("Please enter Robot details:");
                var input = Console.ReadLine();
                validInput = ValidateRobotInput(input);
                if (!validInput) Console.WriteLine("Input was invalid - please try again");
                var robotInput = input.Split(' ').ToArray();
                robotX = int.Parse(robotInput[0]);
                robotY = int.Parse(robotInput[1]);
                robotD = (Heading)Enum.Parse(typeof(Heading), robotInput[2].ToString().ToUpper());
            }
            var robot = new Robot(robotX, robotY, robotD);


            // Instructions collection
            validInput = false;
            var instruction = "";
            while (!validInput)
            {
                Console.WriteLine("Please enter Robot instruction:");
                var input = Console.ReadLine();
                validInput = ValidateRobotInstructionsInput(input);
                if (!validInput) Console.WriteLine("Input was invalid - please try again");
                instruction = input.ToUpper();
            }

            Movement[] instructionArray = new Movement[instruction.Length];

            for (int i = 0; i < instruction.Length; i++)
            {
                instructionArray[i] = (Movement)Enum.Parse(typeof(Movement), instruction[i].ToString().ToUpper());
            }

            var robotInstructions = new RobotInstructions();
            robotInstructions.Robot = robot;
            robotInstructions.Instructions = instructionArray.ToList();

            return robotInstructions;

        }

    }
}
