trip_money_needed = float(input())
available_money = float(input())
spend = 0
days = 0

while True:
    action = input()
    money = float(input())
    days += 1

    if action == 'spend':
        spend += 1

    if spend >= 5:
        print('You can\'t save the money.')
        print(days)
        break

    if action == 'save':
        available_money += money
        spend = 0
    else:
        if money >= available_money:
            available_money = 0
        else:
            available_money -= money

    if available_money >= trip_money_needed:
        print(f'You saved the money for {days} days.')
        break