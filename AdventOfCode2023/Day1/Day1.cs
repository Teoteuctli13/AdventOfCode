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
                res = Regex.Replace(item, @"(?<=o)(n)(?=e)|(?<=e)(igh)(?=t)|(?<=t)(w)(?=o)|(?<=t)(hre)(?=e)|(?<=f)(ou)(?=r)|(?<=f)(iv)(?=e)|(?<=s)(i)(?=x)|(?<=s)(eve)(?=n)|(?<=n)(in)(?=e)", match =>
                {
                    switch (match.Value)
                    {
                        case "n": return "1";
                        case "w": return "2";
                        case "hre": return "3";
                        case "ou": return "4";
                        case "iv": return "5";
                        case "i": return "6";
                        case "eve": return "7";
                        case "igh": return "8";
                        case "in": return "9";
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