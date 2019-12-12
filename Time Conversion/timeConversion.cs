using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        int hours = Int32.Parse(s.Substring(0, 2));
        int secondLastIndex = s.Length - 2;

        if (s[secondLastIndex] == 'P')
        {
            int mHours = hours != 12 ? hours + 12 : hours;
            s = s.Remove(0, 2).Insert(0, mHours.ToString());
        }
        else
        {
            if (hours == 12)
                s = s.Remove(0, 2).Insert(0, "00");
        }

        return s.Remove(secondLastIndex, 2);
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(
            @System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
