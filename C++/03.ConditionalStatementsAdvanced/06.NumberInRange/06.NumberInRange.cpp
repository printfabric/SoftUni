#include <iostream>
using namespace std;

int main()
{
    int num;
    cin >> num;
    
    if (num == 0)
    {
        cout << "No";
    }
    else if (num >= -100 && num <= 100)
    {
        cout << "Yes";
    }
    else
    {
        cout << "No";
    }
}