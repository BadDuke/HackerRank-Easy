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
    // Complete the formingMagicSquare function below.
    static int formingMagicSquare(int[,] s)
    {
        // I wasn't able to come up with anything more clever than this in a reasonable amount of time.
        // I altered the Main code to use int[,] (non-jagged) rather than int[][]
        // Generally with these hackerRank problems I've been working with the pre-existing Main code as a constraint

        int[, ,] magicSquares = new int[8, 3, 3]
        {
            {{8, 1, 6}, {3, 5, 7}, {4, 9, 2}},
            {{6, 1, 8}, {7, 5, 3}, {2, 9, 4}},
            {{4, 9, 2}, {3, 5, 7}, {8, 1, 6}},
            {{2, 9, 4}, {7, 5, 3}, {6, 1, 8}},
            {{8, 3, 4}, {1, 5, 9}, {6, 7, 2}},
            {{4, 3, 8}, {9, 5, 1}, {2, 7, 6}},
            {{6, 7, 2}, {1, 5, 9}, {8, 3, 4}},
            {{2, 7, 6}, {9, 5, 1}, {4, 3, 8}}
        };

        int minCost = Int32.MaxValue;

        for (int i = 0; i < 8; i++)
        {
            int cost = 0;

            for (int j = 0; j < 3; j++) 
            {
                for (int k = 0; k < 3; k++)
                {
                    cost += Math.Abs(s[j, k] - magicSquares[i, j, k]);
                }
            }

            minCost = Math.Min(minCost, cost);
        }

        return minCost;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[,] s = new int[3, 3];

        for (int i = 0; i < 3; i++)
        { 
           int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), input => Convert.ToInt32(input));

            for (int j = 0; j < temp.Length; j++)
            {
                s[i, j] = temp[j];
            }
        }

        int result = formingMagicSquare(s);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
