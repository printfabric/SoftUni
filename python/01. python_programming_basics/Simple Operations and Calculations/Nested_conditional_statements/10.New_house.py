flowers_type = input()
flowers_count = int(input())
budget = int(input())
sum = 0

if flowers_type == 'Roses':
    sum += flowers_count * 5
    if flowers_count > 80:
        sum *= 0.9
elif flowers_type == 'Dahlias':
    sum += flowers_count * 3.8
    if flowers_count > 90:
        sum *= 0.85
elif flowers_type == 'Tulips':
    sum += flowers_count * 2.8
    if flowers_count > 80:
        sum *= 0.85
elif flowers_type == 'Narcissus':
    sum += flowers_count * 3
    if flowers_count < 120:
        sum *= 1.15
elif flowers_type == 'Gladiolus':
    sum += flowers_count * 2.5
    if flowers_count < 80:
        sum *= 1.2

if budget >= sum:
    print(f"Hey, you have a great garden with {flowers_count} {flowers_type} and {budget - sum:.2f} leva left.")
else:
    print(f'Not enough money, you need {sum - budget:.2f} leva more.')