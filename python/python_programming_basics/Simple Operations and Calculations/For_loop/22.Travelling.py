destination = input()


while destination != 'End':
    price = float(input())
    sum = 0
    while sum < price:
        money = float(input())
        sum += money

    print(f'Going to {destination}!')
    destination = input()
