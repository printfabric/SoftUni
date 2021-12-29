#include <iostream>
#include <string> 
using namespace std;

int main()
{
	string num;
	cin >> num;

	int sum = 0;

	while (num != "Stop")
	{
		sum += stoi(num);
		cin >> num;
	}

	cout << sum;
}