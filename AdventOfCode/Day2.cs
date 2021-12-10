using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day2
    {
        Utilities utilities = new Utilities();
        public Day2()
        {
        }
        public void Challenge1()
        {
            string input = utilities.ReadFile("Day2.txt");
            List<string> sailRoute= input.Split("\n").ToList();
            Submarine submarine = new Submarine();
            foreach (var step in sailRoute)
            {
                List<string> handling = step.Split(" ").ToList();
                if (handling[0].Equals("forward"))
                {
                    submarine.SetXPosition(int.Parse(handling[1]));
                }
                else if (handling[0].Equals("down"))
                {
                    submarine.SetYPosition(int.Parse(handling[1]));
                }
                else
                {
                    submarine.SetYPosition(-int.Parse(handling[1]));
                }
            }

            (int, int) position = submarine.GetPosition();
            Console.WriteLine(position.Item1 * position.Item2);
            Console.ReadLine();
        }
        public void Challenge2()
        {
            string input = utilities.ReadFile("Day2.txt");
            List<string> sailRoute = input.Split("\n").ToList();
            Submarine submarine = new Submarine();
            foreach (var step in sailRoute)
            {
                List<string> handling = step.Split(" ").ToList();
                if (handling[0].Equals("forward"))
                {
                    submarine.SetXPosition(int.Parse(handling[1]));
                    submarine.SetYPosition(int.Parse(handling[1])*submarine.GetAim());
                }
                else if (handling[0].Equals("down"))
                {
                    submarine.SetAim(int.Parse(handling[1]));
                }
                else
                {
                    submarine.SetAim(-int.Parse(handling[1]));
                }
            }

            (int, int) position = submarine.GetPosition();
            Console.WriteLine(position.Item1 * position.Item2);
            Console.ReadLine();

        }        
    }    
}
