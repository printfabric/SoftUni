#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    int dogsCount;
    int otherAnimalsCount;

    cin >> dogsCount;
    cin >> otherAnimalsCount;

    double result = (dogsCount * 2.5) + (otherAnimalsCount * 4);
   
    cout.setf(ios::fixed);
    cout.precision(2);

    cout << result << " lv.";

    return 0;
}