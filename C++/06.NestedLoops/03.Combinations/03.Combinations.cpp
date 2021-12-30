#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    int counter = 0;

    for (size_t i = 0; i <= n; i++)
    {
        for (size_t j = 0; j <= n; j++)
        {
            for (size_t k = 0; k <= n; k++)
            {
                if (i + j + k == n)
                {
                    counter++;
                }
            }
        }
    }

    cout << counter;
}