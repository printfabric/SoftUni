#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    int minValues = INT_MAX;

    while (n)
    {
        n--;

        int num;
        cin >> num;

        if (num < minValues)
        {
            minValues = num;
        }

    }

    cout << minValues;
}

