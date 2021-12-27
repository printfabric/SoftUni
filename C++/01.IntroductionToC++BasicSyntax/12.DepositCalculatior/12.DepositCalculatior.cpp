#include <iostream>
using namespace std;

int main()
{
    double depositАmount;
    int depositTerm;
    double annualInterestRate;

    cin >> depositАmount;
    cin >> depositTerm;
    cin >> annualInterestRate;

    double sum = depositАmount + depositTerm * ((depositАmount * (annualInterestRate / 100)) / 12);
    cout << sum;

    return 0;
}