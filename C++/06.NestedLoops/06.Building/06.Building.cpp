#include <iostream>
using namespace std;

int main()
{
	int floors;
	int rooms;

	cin >> floors;
	cin >> rooms;

	for (size_t i = floors; i > 0; i--)
	{
		for (size_t j = 0; j < rooms; j++)
		{
			if (i == floors)
			{
				cout << "L" << i << j << " ";
			}
			else if (i % 2 == 0)
			{
				cout << "O" << i << j << " ";
			}
			else
			{
				cout << "A" << i << j << " ";
			}
		}

		cout << endl;
	}
}