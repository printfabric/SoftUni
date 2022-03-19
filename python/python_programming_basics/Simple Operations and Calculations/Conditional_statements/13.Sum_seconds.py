import math

time_first = int(input())
time_second = int(input())
time_third = int(input())
total_time = time_first + time_second + time_third

seconds = total_time % 60
hours = math.floor(total_time / 60)

if seconds > 9:
    print(f"{hours}:{seconds}")
else:
    print(f"{hours}:0{seconds}")