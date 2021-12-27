#include <iostream>
using namespace std;

int main()
{
    int lengthInCm;
    int widthInCm;
    int heightInCm;
    double percentage;

    cin >> lengthInCm;
    cin >> widthInCm;
    cin >> heightInCm;
    cin >> percentage;

    double aquariumVolume = lengthInCm * widthInCm * heightInCm;
    double littersThatCanContains = aquariumVolume * 0.001;
    double actualLiters = littersThatCanContains * (1 - (percentage * 0.01));

    cout.setf(ios::fixed);
    cout.precision(02);

    cout << actualLiters;
}