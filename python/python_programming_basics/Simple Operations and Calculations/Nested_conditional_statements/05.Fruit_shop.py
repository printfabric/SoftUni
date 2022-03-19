fruit = input()
day_of_week = input()
quantity = float(input())
sum = 0
error = 0

if day_of_week == 'Saturday' or day_of_week == 'Sunday':
    if fruit == 'banana':
        sum += 2.7
    elif fruit == 'apple':
        sum += 1.25
    elif fruit == 'orange':
        sum += 0.90
    elif fruit == 'grapefruit':
        sum += 1.60
    elif fruit == 'kiwi':
        sum += 3.0
    elif fruit == 'pineapple':
        sum += 5.6
    elif fruit == 'grapes':
        sum += 4.20
    else:
        error += 1
elif day_of_week == 'Monday' or day_of_week == 'Tuesday' or day_of_week == 'Wednesday' or day_of_week == 'Thursday' or day_of_week == 'Friday':
    if fruit == 'banana':
        sum += 2.5
    elif fruit == 'apple':
        sum += 1.2
    elif fruit == 'orange':
        sum += 0.85
    elif fruit == 'grapefruit':
        sum += 1.45
    elif fruit == 'kiwi':
        sum += 2.7
    elif fruit == 'pineapple':
        sum += 5.5
    elif fruit == 'grapes':
        sum += 3.85
    else:
        error += 1
else:
    error += 1

if error > 0:
    print("error")
else:
    sum *= quantity
    print(f"{sum:.2f}")
