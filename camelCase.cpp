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

using namespace std;

int numberOfWords(string word) {
	// returns the number of words contained in a camelCase string
	
    /* Constraint: string isn't empty, therefore total is at least one.
	   Checking for uppercase characters won't spot the first word in camelCase.
	   Therefore we set total to 1, then check for uppercase letters from there.
	*/
	int total = 1;
    for (int i = 0; i < word.length(); i++) {
        if (isupper(word[i])) {
            total++;
        }
    }
    return total;
}

int main(){
    string s;
    cin >> s;
    cout << numberOfWords(s) << endl;
    return 0;
}