trip_price = float(input())
puzzle_count = int(input())
talking_dolls_count = int(input())
tedy_bears_count = int(input())
minions_count = int(input())
trucks_count = int(input())

toy_count = puzzle_count + talking_dolls_count + \
            tedy_bears_count + minions_count + trucks_count

sum = puzzle_count * 2.6 + talking_dolls_count * 3 + \
      tedy_bears_count * 4.1 + minions_count * 8.2 + trucks_count * 2

if toy_count >= 50:
    sum *= 0.75

sum *= 0.9

if sum >= trip_price:
    print(f"Yes! {sum - trip_price:.2f} lv left.")
else:
    print(f"Not enough money! {trip_price - sum:.2f} lv needed.")