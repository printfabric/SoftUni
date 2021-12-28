#include <iostream>
using namespace std;

int main()
{
    string product;
    string city;
    double quantity;

    cin >> product;
    cin >> city;
    cin >> quantity;

    double coffee;
    double water;
    double beer;
    double sweets;
    double peanuts;

    if (city == "Sofia")
    {
        coffee = 0.5;
        water = 0.8;
        beer = 1.2;
        sweets = 1.45;
        peanuts = 1.6;

        if (product == "coffee")
        {
            cout << coffee * quantity;
        }
        else if (product == "water")
        {
            cout << water * quantity;
        }
        else if (product == "beer")
        {
            cout << beer * quantity;
        }
        else if (product == "sweets")
        {
            cout << sweets * quantity;
        }
        else if (product == "peanuts")
        {
            cout << peanuts * quantity;
        }

    }
    else if (city == "Plovdiv")
    {
        coffee = 0.4;
        water = 0.7;
        beer = 1.15;
        sweets = 1.3;
        peanuts = 1.5;

        if (product == "coffee")
        {
            cout << coffee * quantity;
        }
        else if (product == "water")
        {
            cout << water * quantity;
        }
        else if (product == "beer")
        {
            cout << beer * quantity;
        }
        else if (product == "sweets")
        {
            cout << sweets * quantity;
        }
        else if (product == "peanuts")
        {
            cout << peanuts * quantity;
        }

    }
    else if (city == "Varna")
    {
        coffee = 0.45;
        water = 0.7;
        beer = 1.1;
        sweets = 1.35;
        peanuts = 1.55;

        if (product == "coffee")
        {
            cout << coffee * quantity;
        }
        else if (product == "water")
        {
            cout << water * quantity;
        }
        else if (product == "beer")
        {
            cout << beer * quantity;
        }
        else if (product == "sweets")
        {
            cout << sweets * quantity;
        }
        else if (product == "peanuts")
        {
            cout << peanuts * quantity;
        }

    }

}