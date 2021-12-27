#include <iostream>
using namespace std;

int main()
{
    int pagesNum;
    int pagesPerHour;
    int daysCount;

    cin >> pagesNum;
    cin >> pagesPerHour;
    cin >> daysCount;

    int result = (pagesNum / pagesPerHour) / daysCount;

    cout << result;
}