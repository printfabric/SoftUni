#include <iostream>
using namespace std;

int main()
{
    string animal;
    cin >> animal;

    if (animal == "dog")
    {
        cout << "mammal";
    }
    else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
    {
        cout << "reptile";
    }
    else
    {
        cout << "unknown";
    }

}