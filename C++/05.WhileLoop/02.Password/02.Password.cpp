#include <iostream>
using namespace std;

int main()
{
	string name;
	string pass;
	string userInput;

	cin >> name;
	cin >> pass;
	cin >> userInput;

	while (pass != userInput)
	{
		cin >> userInput;
	}

	cout << "Welcome " << name << "!";
}