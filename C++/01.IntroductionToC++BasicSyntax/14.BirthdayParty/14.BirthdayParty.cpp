#include <iostream>
using namespace std;

int main()
{
    int rent;
    cin >> rent;

    double cake = rent * 0.2;
    double beverages = cake * 0.55;
    double animator = rent / 3;
    double result = rent + cake + beverages + animator;

    cout << result;
}