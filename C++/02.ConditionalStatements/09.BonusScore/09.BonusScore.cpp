#include <iostream>
using namespace std;

int main()
{
    double bonusPoints = 0.0;
    int num;

    cin >> num;

    if (num % 2 == 0)
    {
        bonusPoints++;
    }

    if (num % 10 == 5)
    {
        bonusPoints += 2;
    }

    if (num <= 100)
    {
        bonusPoints += 5;
    }
    else if (num > 100 && num <= 1000)
    {
        bonusPoints += num * 0.20;
    }
    else if (num > 1000)
    {
        bonusPoints += num * 0.1;
    }

    cout << bonusPoints << endl;
    cout << num + bonusPoints;
}