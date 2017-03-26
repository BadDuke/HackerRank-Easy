#include <map>
#include <set>
#include <list>
#include <cmath>
#include <ctime>
#include <deque>
#include <queue>
#include <stack>
#include <string>
#include <bitset>
#include <cstdio>
#include <limits>
#include <vector>
#include <climits>
#include <cstring>
#include <cstdlib>
#include <fstream>
#include <numeric>
#include <sstream>
#include <iostream>
#include <algorithm>
#include <unordered_map>

https://www.hackerrank.com/challenges/compare-the-triplets

/*********************************************************/


using namespace std;

int main() {
	/* Compare the numbers in Alice's and Bob's number containers at each index and
	   return the tally as two space-separated numbers.
	*/
    
    int aResult = 0;
    int bResult = 0;
    int a0, a1, a2, b0, b1, b2;
    
	// accept two lines off 3 space-separated numbers from user
    cin >> a0 >> a1 >> a2;
    cin >> b0 >> b1 >> b2;
    
	// place each row's numbers into their own respective containers
    int aliceScores[] {a0, a1, a2};
    int bobScores[] {b0, b1, b2};
    
    // Loop until i < length of the aliceScores, same length as bobScores.
    // ints are 4 bytes, so dividing size by 4 gives length.
    for (int i = 0; i < (sizeof(aliceScores) / 4); i++) {
		
        if (aliceScores[i] > bobScores[i]) {
            aResult++;
        }
        if (aliceScores[i] < bobScores[i]) {
            bResult++;
        }
     // else, the scores are equivalent, so don't add to either total.
    }
    
    cout << aResult << " " << bResult << endl;
    return 0;
}
