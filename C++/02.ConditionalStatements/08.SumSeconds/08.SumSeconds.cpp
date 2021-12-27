#include <iostream>
using namespace std;

int main()
{
    int firstRacer, secondRacer, thirdRacer;
    cin >> firstRacer >> secondRacer >> thirdRacer;

    int totalTime = firstRacer + secondRacer + thirdRacer;

    int minutes;
    int seconds;
    
    minutes = totalTime / 60;
    seconds = totalTime % 60;

    if (seconds < 10)
    {
        cout << minutes << ":0" << seconds;
    }
    else
    {
        cout << minutes << ":" << seconds;
    }

}