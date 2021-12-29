#include <iostream>
using namespace std;


int main()
{
	int n;
	cin >> n;

	double sum = 0;

	cout.setf(ios::fixed);
	cout.precision(2);

	while (n)
	{
		n--;

		double input;
		cin >> input;

		if (input < 0)
		{
			cout << "Invalid operation!" << endl;
			break;
		}

		sum += input;

		cout << "Increase: " << input << endl;
	}

	cout << "Total: " << sum;
}