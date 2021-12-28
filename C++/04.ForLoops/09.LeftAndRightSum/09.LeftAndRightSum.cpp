#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    int firstHalfSum = 0;
    int secondHalfSum = 0;

    for (size_t i = 0; i < n; i++)
    {
        int num;
        cin >> num;

        firstHalfSum += num;
    }

    for (size_t i = 0; i < n; i++)
    {
        int num;
        cin >> num;

        secondHalfSum += num;
    }

    if (firstHalfSum == secondHalfSum)
    {
        cout << "Yes, sum = " << firstHalfSum;
    }
    else
    {
        cout << "No, diff = " << abs (firstHalfSum - secondHalfSum);
    }

}