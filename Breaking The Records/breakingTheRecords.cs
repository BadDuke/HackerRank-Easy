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

class Solution
{
    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {    
        if (scores.Length < 2)
            return new int[] { 0, 0 };

        int newHighScoreCount = 0;
        int newLowScoreCount = 0;
        int highScore = scores[0];
        int lowScore = highScore;
        
        for (int i = 1; i < scores.Length; i++)
        {
            int score = scores[i];

            if (score > highScore)
            {
                highScore = score;
                newHighScoreCount++;
            }
            else if (score < lowScore)
            {
                lowScore = score;
                newLowScoreCount++;
            }
        }

        return new int[] { newHighScoreCount, newLowScoreCount };
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());
        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));
        textWriter.Flush();
        textWriter.Close();
    }
}
