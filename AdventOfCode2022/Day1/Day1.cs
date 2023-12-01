using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace AdventOfCode2022.Day1
{
    public static class Day1
    {
        private static string day = MethodBase.GetCurrentMethod().DeclaringType.Name;

        public static void CalculateA()
        {
            var input = IO.ReadInputFileStringArray(day, "a");

            var fap = IO.ReadInputFileStringArrayBlankLine(day, "a");

            string result = "NOT SOLVED YET";
            IO.WriteOutput(day, "a", result);
        }
        public static void CalculateB()
        {
            var input = IO.ReadInputFileStringArray(day, "a");


            string result = "NOT SOLVED YET";
            IO.WriteOutput(day, "b", result);
        }
    }
}
