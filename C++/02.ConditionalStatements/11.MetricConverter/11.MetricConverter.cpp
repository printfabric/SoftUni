#include <iostream>
using namespace std;

int main()
{
    double number;
    string firstUnit;
    string secondUnit;

    cin >> number;
    cin >> firstUnit;
    cin >> secondUnit;

    double result;

    if (firstUnit == "mm")
    {
        if (secondUnit == "cm")
        {
            result = number / 10;
        }
        else
        {
            result = number / 1000;
        }
    }
    else if (firstUnit == "cm")
    {
        if (secondUnit == "mm")
        {
            result = number * 10;
        }
        else
        {
            result = number / 100;
        }
    }
    else
    {
        if (secondUnit == "mm")
        {
            result = number * 1000;
        }
        else
        {
            result = number * 100;
        }
    }

    cout.setf(ios::fixed);
    cout.precision(3);

    cout << result;
}