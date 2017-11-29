using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// http://hackerrank.com/challanges/a-very-big-sum

class Solution {

    static void Main(String[] args) {
		// Read the first input line, a pointless necessity in my solution
        Console.ReadLine();
		// Read a line of space-separated integers and split them off into an array
        string[] arr_temp = Console.ReadLine().Split(' ');
		// Add the input number strings to a new array as ints
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        // Calculate and output the sum of integers as a long
        Console.WriteLine(arr.Sum(i=>(long)i));
    }
}
