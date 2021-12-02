using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day1
    {
        Utilities utilities = new Utilities();
        public Day1()
        {
        }

        public void Challenge1()
        {
            int increases = 0;
            string content = utilities.ReadFile("Day1.txt");
            List<int> deapthMeassures = content.Split("\n").Select(Int32.Parse).ToList();
            for (int i = 1; i < deapthMeassures.Count; i++)
            {

                if (deapthMeassures[i] > deapthMeassures[i - 1])
                {
                    increases++;
                }
            }
            Console.WriteLine(increases);
            Console.ReadLine();
        }
        public void Challenge2()
        {
            int increases = 0;
            string content = utilities.ReadFile("Day1.txt");
            List<int> deapthMeassures = content.Split("\n").Select(Int32.Parse).ToList();
            for (int i = 1; i < deapthMeassures.Count-2; i++)
            {
                int a = deapthMeassures[i - 1] + deapthMeassures[i] + deapthMeassures[i + 1];
                int b = deapthMeassures[i] + deapthMeassures[i + 1] + deapthMeassures[i + 2];

                if (a<b)
                {
                    increases++;
                }
            }
            Console.WriteLine(increases);
            Console.ReadLine();
        }
    }
}
