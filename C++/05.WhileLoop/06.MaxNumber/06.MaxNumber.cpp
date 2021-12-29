#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    int maxValue = INT_MIN;

    while (n)
    {
        n--;

        int num;
        cin >> num;

        if (num > maxValue)
        {
            maxValue = num;
        }

    }

    cout << maxValue;
}

