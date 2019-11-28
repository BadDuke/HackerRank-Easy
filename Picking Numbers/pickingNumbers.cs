using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public static int pickingNumbers(List<int> a)
    {
        a.Sort();
        int currentStreak = 1;
        int longestStreak = 1;
        int firstNumber = a[0];
        int firstCopies = 1;
        int secondCopies = 0;

        for (int i = 1; i < a.Count; i++)
        {
            if (Math.Abs(a[i] - firstNumber) <= 1)
            {
                currentStreak++;

                if (a[i] == firstNumber)
                {
                    firstCopies++;
                }
                else {
                    secondCopies++;
                }
            }
            else {
                if (Math.Abs(a[i] - a[i - 1]) == 1)
                {
                    firstNumber = a[i - 1];
                    firstCopies = secondCopies;
                    secondCopies = 1;
                }
                else
                {
                    firstNumber = a[i];
                    firstCopies = 1;
                    secondCopies = 0;
                }
                if (longestStreak < currentStreak)
                {
                    longestStreak = currentStreak;
                }

                currentStreak = firstCopies + secondCopies;
            }
        }
        
        return longestStreak > currentStreak ? longestStreak : currentStreak;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
