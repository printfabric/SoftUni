days_to_stay = int(input())
type_of_room = input()
evaluation = input()
sum = 0

if type_of_room == "room for one person":
    sum += (days_to_stay - 1)* 18

elif type_of_room == 'apartment':
    sum += (days_to_stay - 1)* 25

    if days_to_stay < 10:
        sum *= 0.70
    elif days_to_stay >= 10 and days_to_stay <= 15:
        sum *= 0.65
    elif days_to_stay > 15:
        sum *= 0.5
elif type_of_room == 'president apartment':
    sum += (days_to_stay - 1) * 35

    if days_to_stay < 10:
        sum *= 0.9
    elif days_to_stay >= 10 and days_to_stay <= 15:
        sum *= 0.85
    elif days_to_stay > 15:
        sum *= 0.8

if(evaluation == 'positive'):
    sum *= 1.25
else:
    sum *= 0.9

print(f'{sum:.2f}')