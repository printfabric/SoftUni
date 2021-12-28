#include <iostream>
using namespace std;

int main()
{
    string typeOfFruit;
    string dayOfWeek;
    double quantity;

    cin >> typeOfFruit;
    cin >> dayOfWeek;
    cin >> quantity;

    double result = 0.0;

    if (dayOfWeek == "Sunday" || dayOfWeek == "Saturday")
    {
        double banana = 2.7;
        double apple = 1.25;
        double orange = 0.9;
        double grapefruit = 1.6;
        double kiwi = 3.0;
        double pineapple = 5.6;
        double grapes = 4.2;

        if (typeOfFruit == "banana")
        {
            result += banana * quantity;
        }
        else if (typeOfFruit == "apple")
        {
            result += apple * quantity;
        }
        else if (typeOfFruit == "orange")
        {
            result += orange * quantity;
        }
        else if (typeOfFruit == "grapefruit")
        {
            result += grapefruit * quantity;
        }
        else if (typeOfFruit == "kiwi")
        {
            result += kiwi * quantity;
        }
        else if (typeOfFruit == "pineapple")
        {
            result += pineapple * quantity;
        }
        else if (typeOfFruit == "grapes")
        {
            result += grapes * quantity;
        }
       
    }
    else if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" ||
        dayOfWeek == "Thursday" || dayOfWeek == "Friday")
    {
        double banana = 2.5;
        double apple = 1.20;
        double orange = 0.85;
        double grapefruit = 1.45;
        double kiwi = 2.7;
        double pineapple = 5.5;
        double grapes = 3.85;

        if (typeOfFruit == "banana")
        {
            result += banana * quantity;
        }
        else if (typeOfFruit == "apple")
        {
            result += apple * quantity;
        }
        else if (typeOfFruit == "orange")
        {
            result += orange * quantity;
        }
        else if (typeOfFruit == "grapefruit")
        {
            result += grapefruit * quantity;
        }
        else if (typeOfFruit == "kiwi")
        {
            result += kiwi * quantity;
        }
        else if (typeOfFruit == "pineapple")
        {
            result += pineapple * quantity;
        }
        else if (typeOfFruit == "grapes")
        {
            result += grapes * quantity;
        }
    }

    cout.setf(ios::fixed);
    cout.precision(2);

    if (result > 0.0)
    {
        cout << result;
    }
    else
    {
        cout << "error";
    }
}