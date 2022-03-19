hours = int(input())
minutes = int(input())

minutes_plus = (minutes + 15) % 60

if (minutes + 15) >= 60:
    if(hours == 23):
        hours = 0
    else:
        hours += 1

if minutes_plus < 10:
    minutes_plus = "0" + str(minutes_plus)

print(f"{hours}:{minutes_plus}")