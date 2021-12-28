#include <string>
#include <iostream>
using namespace std;

int main()
{
    string text;

    getline(cin, text);

	for (size_t i = 0; i < text.length(); i++)
	{
		cout << text[i] << endl; 
	}
}