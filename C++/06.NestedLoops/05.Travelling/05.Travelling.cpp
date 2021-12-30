#include <iostream>
#include <string>

using namespace std;

int main()
{
	string destination;
	int needeBudget;
	int inputNum;

	int savingsSum = 0;

	while (true)
	{
		cin >> destination;

		if (destination == "End")
			break;

		cin >> needeBudget;

		while (savingsSum < needeBudget)
		{
			cin >> inputNum;
			savingsSum += inputNum;
		}

		savingsSum = 0;

		cout << "Going to " << destination << "!" << endl;
	}

}