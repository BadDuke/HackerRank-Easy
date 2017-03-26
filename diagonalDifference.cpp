#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

// https://www.hackerrank.com/challenges/diagonal-difference

/**********************************************************/


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