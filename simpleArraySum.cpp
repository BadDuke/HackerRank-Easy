#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>

// https://www.hackerrank.com/challenges/simple-array-sum

/*******************************************************/


using namespace std;

int main(){
    int n;
    int sum = 0;
    
    cin >> n; // accept a number for the container size
    vector<int> numVec(n); // create the container
	
    for(int i = 0; i < n; i++){
       cin >> numVec[i]; // take user input number and place into vector at specified index
       sum += numVec[i]; // add that sumber to our sum
    }
	
    cout << sum << endl;
    return 0;
}
