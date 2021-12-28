#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    int oddSum = 0;
    int evenSum = 0;

    for (size_t i = 0; i < n; i++)
    {
        int num;
        cin >> num;

        if (i % 2 == 0)
        {
            evenSum += num;
        }
        else
        {
            oddSum += num;
        }

    }

    if (evenSum == oddSum)
    {
        cout << "Yes" << endl;
        cout << "Sum = " << evenSum;
    }
    else
    {
        cout << "No" << endl;
        cout << "Diff = " << abs(evenSum - oddSum);
    }

}