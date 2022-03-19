n = int(input())
list = [0] * n
command = input().split()

while command[0] != 'End':
    if command[0] == 'add':
        people = int(command[1])
        list[-1] += people
    elif command[0] == 'insert':
        index = int(command[1])
        people = int(command[2])
        list[index] += people
    elif command[0] == 'leave':
        index = int(command[1])
        people = int(command[2])
        list[index] -= people
    elif command[0] == 'End':
        break
    command = input().split()

print(list)
