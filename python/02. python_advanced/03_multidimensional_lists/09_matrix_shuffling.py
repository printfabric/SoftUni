row, col = [int(x) for x in input().split()]
matrix = []

for r in range(row):
    matrix.append([x for x in input().split()])

commands = input().split()

while commands[0] != 'END':
    command = commands[0]
    if len(commands) == 5 and command == 'swap':
        row1 = int(commands[1])
        col1 = int(commands[2])
        row2 = int(commands[3])
        col2 = int(commands[4])

        if row1 <= row \
                and col1 <= col \
                and row2 <= row \
                and col2 <= col:
            matrix[row1][col1], matrix[row2][col2] = matrix[row2][col2], matrix[row1][col1]

            for r in range(row):
                print(' '.join(map(str, matrix[r])))
        else:
            print("Invalid input!")

    else:
        print("Invalid input!")

    commands = input().split()
