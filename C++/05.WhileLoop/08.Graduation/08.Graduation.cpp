#include <iostream>
using namespace std;

int main()
{
    string studentName;
    cin >> studentName;

    int grade = 12;
    double sum = 0;

    while (grade)
    {
        grade--;

        double input;
        cin >> input;

        sum += input;
    }

    cout.setf(ios::fixed);
    cout.precision(2);

    double averageGrade = sum / 12;

    if (averageGrade >= 4)
    {
        cout << studentName << " graduated. Average grade: " << averageGrade;
    }

}
