#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    string name;
    string lastName;
    int age;
    string town;
    
    cin >> name;
    cin >> lastName;
    cin >> age;
    cin >> town;

    cout << "You are " << name << " " << lastName << ", a " << age 
        << "-years old person from " << town << ".";
}