#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

// https://www.hackerrank.com/challenges/diagonal-difference

// NEWER SOLUTION:
// A solution that avoids using arrays/vectors to store and pass data around
/**************************************************************************/

int main(){
    
    int n, input; // Number of rows and columns
    int pDiagonal = 0; // Sum of numbers from upper left to lower right
    int sDiagonal = 0; // Sum of numbers from upper right to lower left
    cin >> n;
    
    // For each index (column) of each row...
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cin >> input; // Fill with an int
            // If current row index and column index are the same...
            if (i == j) {
                pDiagonal += input;
            }
            /* If the int we're hitting in the row + i == n-1...
            In other words, if on last number of first row, second last of second row etc...
            */
            if (i+j == (n-1)) {
                sDiagonal += input;
            }
        }
    }
    // print the absolute difference between the primary and secondary diagonals of the matrix
    cout << abs(pDiagonal - sDiagonal);
    
    return 0;
}


// ORIGINAL SOLUTION (default problem state had setup for a vector matrix)
/************************************************************************/

int main(){
    
    // Variables for number of rows, and diagonal sums
    int n;
    int pDiagonal = 0;
    int sDiagonal = 0;
    cin >> n;
    // Initialize a vector of vectors for our square matrix of ints
    vector<vector<int>> a(n, vector<int>(n));
    
    // For every spot (column) in each row...
    for (int i = 0; i < n; i++) {
       for(int j = 0; j < n; j++) {
           // Prompt for input and insert it there
           cin >> a[i][j];
       }
       /* Once each row is filled, add to pDiagonal's sum the number
       at [i] of that row, where 'i' is which row we're on.
       Thus, add number at coordinate 0-0, then 1-1, 2-2, 3-3... (asc)
       */
       pDiagonal += a[i][i];
       /* Do the same for sDiagonal but backwards from the upper right.
       For a square matrix, n is always final row index + 1, so...
       */
       sDiagonal += a[i][(n-1)-i];
       // If matrix is 4-by-4, this adds to sDiagonal 3-3, 2-2, 1-1, 0-0 (desc)
    }
    
    cout << abs(pDiagonal - sDiagonal);
    
    return 0;
}
