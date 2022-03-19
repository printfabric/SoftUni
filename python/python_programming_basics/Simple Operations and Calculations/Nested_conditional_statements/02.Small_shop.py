product = input()
town = input()
quantity = float(input())
sum = 0

if town == "Sofia":
    if product == 'coffee':
        sum += 0.5
    elif product == 'water':
        sum += 0.8
    elif product == 'beer':
        sum += 1.2
    elif product == 'sweets':
        sum += 1.45
    elif product == 'peanuts':
        sum += 1.6
elif town == "Plovdiv":
    if product == 'coffee':
        sum += 0.4
    elif product == 'water':
        sum += 0.7
    elif product == 'beer':
        sum += 1.15
    elif product == 'sweets':
        sum += 1.30
    elif product == 'peanuts':
        sum += 1.5
elif town == "Varna":
    if product == 'coffee':
        sum += 0.45
    elif product == 'water':
        sum += 0.70
    elif product == 'beer':
        sum += 1.1
    elif product == 'sweets':
        sum += 1.35
    elif product == 'peanuts':
        sum += 1.55

sum *= quantity
print(sum)