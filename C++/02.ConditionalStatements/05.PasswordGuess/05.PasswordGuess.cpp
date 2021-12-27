#include <iostream>
using namespace std;

int main()
{
    string pass = "s3cr3t!P@ssw0rd";

    string userInput;

    cin >> userInput;

    if (userInput == pass)
    {
        cout << "Welcome";
    }
    else
    {
        cout << "Wrong password!";
    }

}
