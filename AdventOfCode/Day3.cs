using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day3
    {
        Utilities utilities = new Utilities();
        DiagnosticReport diagnosticReport = new();
        public Day3()
        {
        }
        public void Challenge1()
        {
            int[,] report = diagnosticReport.GetReport();
            StringBuilder stringBuilder = new();
            int gammaRate;
            int epsilonRate;

            
            for (int i = 0; i < report.GetLength(0)-1; i++)
            {                
                foreach (var element in report[i][i])
                {
                    var test = report[i][0];
                }
            }


        }
        public void Challenge2()
        {

        }
    }
}
