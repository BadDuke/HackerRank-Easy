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
    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int totalApples = apples.Length;
        int totalOranges = oranges.Length;
        int minTotal = totalApples < totalOranges ? totalApples : totalOranges;
        int applesInRange = 0;
        int orangesInRange = 0;
        int fruitLocation;

        for (int i = 0; i < minTotal; i++)
        {
            fruitLocation = a + apples[i];
            if (fruitLocation >= s && fruitLocation <= t)
                applesInRange++;

            fruitLocation = b + oranges[i];
            if (fruitLocation <= t && fruitLocation >= s)
                orangesInRange++;
        }

        if (totalApples > minTotal)
        {
            for (int i = minTotal; i < totalApples; i++)
            {
                fruitLocation = a + apples[i];
                if (fruitLocation >= s && fruitLocation <= t)
                    applesInRange++;
            }
        }
        else if (totalOranges > minTotal)
        {
            for (int i = minTotal; i < totalOranges; i++)
            {
                fruitLocation = b + oranges[i];
                if (fruitLocation <= t && fruitLocation >= s)
                    orangesInRange++;
            }
        }

        Console.Write($"{applesInRange}\n{orangesInRange}");
    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);
        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);
        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);
        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
