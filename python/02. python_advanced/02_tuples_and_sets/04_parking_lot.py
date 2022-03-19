n = int(input())
parking = set()

for i in range(n):
    direction, number_plate = input().split(", ")

    if direction == 'IN':
        parking.add(number_plate)

    if direction == 'OUT':
        if number_plate in parking:
            parking.remove(number_plate)


if len(parking):
    for car in parking:
        print(car)
else:
    print('Parking Lot is Empty')
