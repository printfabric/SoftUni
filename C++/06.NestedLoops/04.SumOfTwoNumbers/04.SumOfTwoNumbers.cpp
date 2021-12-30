#include <iostream>
#include<string>
using namespace std;

int main()
{
	int start;
	int stop;
	int magicNumber;

	cin >> start;
	cin >> stop;
	cin >> magicNumber;

	int combination = 0;
	int counter = 0;
	string temp = "";

	for (size_t i = start; i <= stop; i++)
	{
		for (size_t j = start; j <= stop; j++)
		{
			combination++;

			if (i + j == magicNumber)
			{
				temp = to_string(i) + " + " + to_string(j) + " = " + to_string(magicNumber);
				counter++;
				break;
			}
		}

		if (counter > 0)
			break;

	}

	if (counter > 0)
	{
		cout << "Combination N:" << combination << " (" << temp << ")";
	}
	else
	{
		cout << combination << " combinations - neither equals " << magicNumber;
	}

}
