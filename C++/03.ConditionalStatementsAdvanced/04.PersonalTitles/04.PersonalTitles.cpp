#include <iostream>
using namespace std;

int main()
{
    double age;
    string gender;

    cin >> age;
    cin >> gender;

    if (gender == "m")
    {
        if (age >= 16)
        {
            cout << "Mr.";
        }
        else
        {
            cout << "Master";
        }
    }
    else
    {
        if (age >= 16)
        {
            cout << "Ms.";
        }
        else
        {
            cout << "Miss";
        }
    }

}