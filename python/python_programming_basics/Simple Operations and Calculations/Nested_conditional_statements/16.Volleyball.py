import math
year = input()
holidays = int(input())
weekends_to_home = int(input())
playable_days = 48
leep_or_not = 1

if year == 'leap':
    leep_or_not = 1.15

games_count = ((((playable_days - weekends_to_home) * (3 / 4)) +
                weekends_to_home) + holidays * 2 / 3) * leep_or_not

print(math.floor(games_count))
