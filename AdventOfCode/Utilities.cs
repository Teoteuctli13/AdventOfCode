using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Utilities
    {
        private string Folder = @"..\..\..\Input\";
        public Utilities()
        {        
        }
        public string ReadFile(string inputFile)
        {
            using (StreamReader streamReader = new StreamReader(Path.Combine(Folder,inputFile)))
            {
                string fileContent = streamReader.ReadToEnd();
                return fileContent;
            }
        }

    }
    public class Submarine
    {
        private int XPosition = 0;
        private int YPosition = 0;
        private int Aim = 0;

        public (int, int) GetPosition()
        {
            return (XPosition, YPosition);
        }
        public int GetAim()
        {
            return Aim;
        }
        public void SetAim(int aimChange)
        {
            Aim += aimChange;
        }
        public void SetXPosition(int xChange)
        {
            XPosition += xChange;
        }
        public void SetYPosition(int yChange)
        {
            YPosition += yChange;
        }
    }

    public class DiagnosticReport
    {
        private Utilities utilities = new();
        private int[,] report;
        public DiagnosticReport()
        {
            string input = utilities.ReadFile("Day3.txt");
            List<string> lines = input.Split("\r\n").ToList();
            int yLength = lines.Count();
            int xLength = lines[0].Length;
            report = new int[xLength, yLength];
            for (int i = 0; i < lines.Count-1; i++)
            {
                for (int j = 0; j < lines[0].Length-1; j++)
                {
                    report[j, i] = int.Parse(lines[i][j].ToString());
                }

            }
        }

        public int[,] GetReport()
        {
            return report;
        }
    }
}
