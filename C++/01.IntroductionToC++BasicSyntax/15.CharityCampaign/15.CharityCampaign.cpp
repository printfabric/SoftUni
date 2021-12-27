#include <iostream>
using namespace std;

int main()
{
    int daysCount;
    int bakersCount;
    int cakeCount;
    int wafflesCount;
    int pancakesCount;

    cin >> daysCount;
    cin >> bakersCount;
    cin >> cakeCount;
    cin >> wafflesCount;
    cin >> pancakesCount;

    double productsMakedByDay = ((cakeCount * 45) + (wafflesCount * 5.8) + (pancakesCount * 3.2))
        * bakersCount;
    double result = (productsMakedByDay * daysCount) * 0.875;

    cout.setf(ios::fixed);
    cout.precision(2);
    
    cout << result;
}