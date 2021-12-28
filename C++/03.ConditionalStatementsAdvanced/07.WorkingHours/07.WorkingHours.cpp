#include <iostream>
using namespace std;

int main()
{
    int hour;
    string dayOfWeek;

    cin >> hour;
    cin >> dayOfWeek;

    if (dayOfWeek == "sunday" || dayOfWeek == "saturday")
    {
        cout << "closed";
    }
    else
    {
        if (hour >= 10 && hour < 18)
        {
            cout << "open";
        }
        else
        {
            cout << "closed";
        }

    }

}