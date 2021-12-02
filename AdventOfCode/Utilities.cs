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
}
