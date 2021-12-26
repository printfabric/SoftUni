#include <iostream>
using namespace std;

int main()
{
    double landscapingArea;
    cin >> landscapingArea;

    double result = landscapingArea * 7.61;
    double discount = result * 0.18;
    result = result * 0.82;
    
    cout.setf(ios::fixed);
    cout.precision(2);

    cout << "The final price is: " << result << " lv." << endl;
    cout << "The discount is: " << discount << " lv.";

    return 0;
}