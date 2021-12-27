#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    double USD;
    cin >> USD;

    double result = USD * 1.79549;

    cout.setf(ios::fixed);
    cout.precision(2);

    cout << result;

    return 0;
}