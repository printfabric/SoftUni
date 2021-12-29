#include <iostream>
using namespace std;

int main()
{
	int n;
	cin >> n;

	int sum = 1;

	while (sum <= n)
	{
		cout << sum << endl;

		sum = (sum * 2) + 1;
	}
}