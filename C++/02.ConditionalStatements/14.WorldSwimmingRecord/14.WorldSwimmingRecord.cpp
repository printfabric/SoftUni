#include <iostream>
#include <tgmath.h>
using namespace std;

int main()
{
    double worldRecordInSec;
    double distanceInM;
    double timeInSeconds;

    cin >> worldRecordInSec;
    cin >> distanceInM;
    cin >> timeInSeconds;

    double additionalTime = floor (distanceInM / 15) * 12.5;
    double result = (distanceInM * timeInSeconds) + additionalTime;

    cout.setf(ios::fixed);
    cout.precision(2);

    if (worldRecordInSec < result)
    {
        cout << "No, he failed! He was " << result - worldRecordInSec << " seconds slower.";
    }
    else
    {
        cout << "Yes, he succeeded! The new world record is " << result << " seconds.";
    }

}