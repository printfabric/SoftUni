#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    int minValue = INT_MAX;
    int maxValue = INT_MIN;

    for (size_t i = 0; i < n; i++)
    {
        int num;
        cin >> num;

        if (num < minValue)
        {
            minValue = num;
        }

        if (num > maxValue)
        {
            maxValue = num;
        }

    }

    cout << "Max number: " << maxValue << endl;
    cout << "Min number: " << minValue << endl;
}