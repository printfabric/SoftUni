from collections import deque

water_quantity = int(input())
queue = deque()

name = input()

while name != 'Start':
    queue.append(name)
    name = input()

command = input().split()

while command[0] != 'End':

    if command[0] == 'refill':
        water_quantity += int(command[1])
    else:
        needed_water = int(command[0])
        if water_quantity >= needed_water:
            print(f"{queue.popleft()} got water")
            water_quantity -= needed_water
        else:
            print(f'{queue.popleft()} must wait')

    command = input().split()

print(f'{water_quantity} liters left')
