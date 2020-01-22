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
    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        var posCount = 0.000000m;
        var negCount = 0.000000m;
        var zerosCount = 0.000000m;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0){
                posCount++;
            }
            else if (arr[i] < 0){
                negCount++;
            }
            else {
                zerosCount++;
            }
        }

        Console.WriteLine(Decimal.Round(Decimal.Divide((decimal)posCount, (decimal)arr.Length), 6));
        Console.WriteLine(Decimal.Round(Decimal.Divide((decimal)negCount, (decimal)arr.Length), 6));
        Console.Write(Decimal.Round(Decimal.Divide((decimal)zerosCount, (decimal)arr.Length), 6));
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}
