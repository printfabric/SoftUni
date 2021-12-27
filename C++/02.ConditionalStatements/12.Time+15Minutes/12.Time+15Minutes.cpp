#include <iostream>
using namespace std;

int main()
{
    int hours;
    int minutes;

    cin >> hours;
    cin >> minutes;

    if (hours == 23)
    {
        if (minutes > 44)
        {
            hours = 0;
            minutes = minutes - 45;
        }
        else
        {
            minutes += 15;
        }
    }
    else
    {
        if (minutes > 44)
        {
            hours++;
            minutes = minutes - 45;
        }
        else
        {
            minutes += 15;
        }
    }

    if (minutes < 10)
    {
        cout << hours << ":0" << minutes;
    }
    else
    {
        cout << hours << ":" << minutes;
    }

}