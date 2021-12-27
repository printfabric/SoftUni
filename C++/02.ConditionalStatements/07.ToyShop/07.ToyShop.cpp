#include <iostream>
using namespace std;

int main()
{
    double pusselPice = 2.6;
    double talkingDollPice = 3;
    double teddyBearPice = 4.1;
    double minionPice = 8.2;
    double truckPice = 2;

    double tripPrice;
    cin >> tripPrice;

    int pusselCount, talkingDollsCount, teddyBearsCount,
        minionsCount, trucksCount;
    cin >> pusselCount >> talkingDollsCount >> teddyBearsCount >>
        minionsCount >> trucksCount;

    double result = (pusselCount * pusselPice) + (talkingDollsCount * talkingDollPice) +
        (teddyBearsCount * teddyBearPice) + (minionsCount * minionPice) +
        (trucksCount * truckPice);

    int toysCount = pusselCount + talkingDollsCount + teddyBearsCount +
        minionsCount + trucksCount;

    cout.setf(ios::fixed);
    cout.precision(2);

    if (toysCount >= 50)
    {
        result = result * 0.75;
    }

    result = result * 0.9;

    if (result >= tripPrice)
    {
        cout << "Yes! " << result - tripPrice << " lv left.";
    }
    else
    {
        cout << "Not enough money! " << tripPrice - result << " lv needed.";
    }

}