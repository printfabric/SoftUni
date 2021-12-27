#include <iostream>
using namespace std;

int main()
{
    double strawberriesPrice;
    double bananasQuantity;
    double orangesQuantity;
    double raspberriesQuantity;
    double strawberriesQuantity;

    cin >> strawberriesPrice;
    cin >> bananasQuantity;
    cin >> orangesQuantity;
    cin >> raspberriesQuantity;
    cin >> strawberriesQuantity;

    double raspberriesPrice = strawberriesPrice * 0.5;
    double orangesPrice = raspberriesPrice * 0.6;
    double bananasPrice = raspberriesPrice * 0.2;

    double result = (strawberriesPrice * strawberriesQuantity) + (bananasPrice * bananasQuantity)
        + (orangesPrice * orangesQuantity) + (raspberriesPrice * raspberriesQuantity);

    cout.setf(ios::fixed);
    cout.precision(2);

    cout << result;
}
