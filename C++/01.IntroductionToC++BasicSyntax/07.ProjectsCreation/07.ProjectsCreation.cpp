#include <iostream>
using namespace std;

int main()
{
    string name;
    int projectNumbers;

    cin >> name;
    cin >> projectNumbers;

    int projectsNededTime = projectNumbers * 3;

    cout << "The architect " << name << " will need " 
        <<projectsNededTime << " hours to complete " 
        << projectNumbers << " project/s.";
}
