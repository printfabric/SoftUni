#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    for (size_t i = 0; i <= n; i+=2)
    {
        cout << pow(2, i) << endl;
    }
}