#define _USE_MATH_DEFINES
#include <iostream>
#include <tgmath.h>
#include < math.h >
using namespace std;

int main()
{
    string figureInput;
    double result;
    double pi = 3.14159265359;

    cin >> figureInput;

    if (figureInput == "square")
    {
        double side;
        cin >> side;

        result = side * side;

    }
    else if (figureInput == "rectangle")
    {
        double side1, side2;
        cin >> side1 >> side2;

        result = side1 * side2;
    }
    else if (figureInput == "circle")
    {
        double radius;
        cin >> radius;

        result = pi * pow(radius, 2);
    }
    else
    {
        double base, height;
        cin >> base >> height;

        result = (base * height) / 2;
    }

    cout.setf(ios::fixed);
    cout.precision(3);

    cout << result;
}