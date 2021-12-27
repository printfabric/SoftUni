#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    double angleInRad;
    cin >> angleInRad;

    double angleInDeg = angleInRad * 180 / 3.14;

    cout << round(angleInDeg);
}