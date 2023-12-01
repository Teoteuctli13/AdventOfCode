using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Utilities;

namespace AdventOfCode2023.Day1
{
    public static class Day1
    {
        private static string day = MethodBase.GetCurrentMethod().DeclaringType.Name;

        public static void CalculateA()
        {
            var input = IO.ReadInputFileStringArray(day, "a");

            int sum = 0;
            foreach (var item in input)
            {
                int a = 0;
                int b = 0;
                var tmpStr = new String(item.Where(Char.IsDigit).ToArray());
                a = int.Parse(tmpStr[0].ToString()) * 10;
                b = int.Parse(tmpStr[^1].ToString());
                sum += a+b;
            }

            int result = sum;
            IO.WriteOutput(day, "a", result);
        }
        public static void CalculateB()
        {
            var input = IO.ReadInputFileStringArray(day, "b");
            
            string res = null;
            int sum = 0;
            foreach (var item in input)
            {
                res = Regex.Replace(item, @"(one|two|three|four|five|six|seven|eight|nine)", match =>
                {
                    switch (match.Value)
                    {
                        case "one": return "o1e";
                        case "two": return "t2o";
                        case "three": return "t3e";
                        case "four": return "f4r";
                        case "five": return "f5e";
                        case "six": return "s6x";
                        case "seven": return "s7n";
                        case "eight": return "e8t";
                        case "nine": return "n9e";
                        default: return match.Value;
                    }
                });
                res = Regex.Replace(res, @"(one|two|three|four|five|six|seven|eight|nine)", match =>
                {
                    switch (match.Value)
                    {
                        case "one": return "o1e";
                        case "two": return "t2o";
                        case "three": return "t3e";
                        case "four": return "f4r";
                        case "five": return "f5e";
                        case "six": return "s6x";
                        case "seven": return "s7n";
                        case "eight": return "e8t";
                        case "nine": return "n9e";
                        default: return match.Value;
                    }
                });

                int a = 0;
                int b = 0;
                var tmpStr = new String(res.Where(Char.IsDigit).ToArray());
                a = int.Parse(tmpStr[0].ToString()) * 10;
                b = int.Parse(tmpStr[^1].ToString());
                sum += a + b;
            }

            int result = sum;


            //string result = "NOT SOLVED YET";
            IO.WriteOutput(day, "b", result);
        }
    }
}