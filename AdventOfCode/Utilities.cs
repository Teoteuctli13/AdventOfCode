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
}
