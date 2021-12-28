#include <iostream>
using namespace std;

int main()
{
    string dayOfWheek;
    cin >> dayOfWheek;

    if (dayOfWheek == "Saturday" || dayOfWheek == "Sunday")
    {
        cout << "Weekend";
    }
    else if (dayOfWheek == "Monday" || dayOfWheek == "Tuesday" || dayOfWheek == "Wednesday" ||
        dayOfWheek == "Thursday" || dayOfWheek == "Friday")
    {
        cout << "Working day";
    }
    else
    {
        cout << "Error";
    }

}