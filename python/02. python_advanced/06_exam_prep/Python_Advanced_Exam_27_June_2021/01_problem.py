chocolate = [int(x) for x in input().split(", ")]
cups_of_milk = [int(x) for x in input().split(", ")]

chocolate_milkshake = 0

while True:

    if(chocolate_milkshake >= 5 or len(chocolate) < 1 or len(cups_of_milk) < 1):
        break

    current_chocolate = chocolate[-1]
    current_cup_of_milk = cups_of_milk[0]

    if current_chocolate <= 0:
        chocolate = chocolate[:-1]
    elif current_cup_of_milk <= 0:
        current_cup_of_milk = cups_of_milk.pop(0)
    else:
        if current_chocolate == current_cup_of_milk:
            chocolate_milkshake += 1
            chocolate = chocolate[:-1]
            current_cup_of_milk = cups_of_milk.pop(0)
        else:
            cups_of_milk.append(cups_of_milk.pop(0))
            chocolate[-1] -= 5


if chocolate_milkshake >= 5:
    print("Great! You made all the chocolate milkshakes needed!")
else:
    print("Not enough milkshakes.")

if len(chocolate) > 0:
    print(f"Chocolate: {', '.join([str(i) for i in chocolate])}")
else:
    print("Chocolate: empty")

if len(cups_of_milk) > 0:
    print(f"Milk: {', '.join([str(i) for i in cups_of_milk])}")
else:
    print("Milk: empty")
