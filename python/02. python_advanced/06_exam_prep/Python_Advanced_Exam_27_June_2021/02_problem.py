matrix = []
my_position = []
target_left = True
counter = 0
targets = 0
count_targets_left = 0
targets_path = []

for i in range(5):
    temp = [x for x in input().split(' ')]
    temp = temp[:-1]
    matrix.append(temp)
    for j in range(len(temp)):
        if temp[j] == "A":
            my_position.append(i)
            my_position.append(j)
    # print(temp)

number_of_commands = int(input())

for i in range(number_of_commands):
    commands = input().split()
    command = commands[0]
    direction = commands[1]

    if command == 'move':
        steps = int(commands[2])

        for i in range(steps):
            if direction == "up":
                if my_position[0] > 0:
                    if matrix[my_position[0] - 1][my_position[1]] == '.':
                        matrix[my_position[0] - 1][my_position[1]], matrix[my_position[0]][my_position[1]] = \
                            matrix[my_position[0]][my_position[1]], matrix[my_position[0] - 1][my_position[1]]
                        my_position[0] -= 1
            elif direction == "down":
                if my_position[0] < 4:
                    if matrix[my_position[0] + 1][my_position[1]] == '.':
                        matrix[my_position[0] + 1][my_position[1]], matrix[my_position[0]][my_position[1]] = \
                            matrix[my_position[0]][my_position[1]], matrix[my_position[0] + 1][my_position[1]]
                        my_position[0] += 1
            elif direction == "left":
                if my_position[1] > 0:
                    if matrix[my_position[0]][my_position[1] - 1] == '.':
                        matrix[my_position[0]][my_position[1] - 1], matrix[my_position[0]][my_position[1]] = \
                            matrix[my_position[0]][my_position[1]], matrix[my_position[0]][my_position[1] - 1]
                        my_position[1] -= 1
            elif direction == "right":
                if my_position[1] < 4:
                    if matrix[my_position[0]][my_position[1] + 1] == '.':
                        matrix[my_position[0]][my_position[1] + 1], matrix[my_position[0]][my_position[1]] = \
                            matrix[my_position[0]][my_position[1]], matrix[my_position[0]][my_position[1] + 1]
                        my_position[1] += 1
            # print()
            # print()
            # for row in matrix:
            #          print(''.join(row))

    elif command == 'shoot':
        for row in matrix:
            if 'x' in row:
                counter = 1

        if counter == 0:
            break

        if counter > 0:
            if direction == 'up':
                if my_position[0] > 0:
                    for i in range(my_position[0], -1, -1):
                        if matrix[i][my_position[1]] == 'x':
                            position = []
                            position.append(i)
                            position.append(my_position[1])
                            targets += 1
                            matrix[i][my_position[1]] = '.'
                            targets_path.append(position[:])
                            break
            elif direction == 'down':
                if my_position[0] < 4:
                    for i in range(my_position[0] + 1, 5):
                        if matrix[i][my_position[1]] == 'x':
                            position = []
                            position.append(i)
                            position.append(my_position[1])
                            targets += 1
                            matrix[i][my_position[1]] = '.'
                            targets_path.append(position[:])
                            break
            elif direction == 'left':
                if my_position[1] > 0:
                    for i in range(my_position[1], -1, -1):
                        if matrix[my_position[0]][i] == 'x':
                            position = []
                            position.append(my_position[0])
                            position.append(i)
                            targets += 1
                            matrix[my_position[0]][i] = '.'
                            targets_path.append(position[:])
                            break
            elif direction == 'right':
                if my_position[1] < 4:
                    for i in range(my_position[1] + 1, 5):
                        if matrix[my_position[0]][i] == 'x':
                            position = []
                            position.append(my_position[0])
                            position.append(i)
                            targets += 1
                            matrix[my_position[0]][i] = '.'
                            targets_path.append(position[:])
                            break

        counter = 0
        # for row in matrix:
        #     print(''.join(row))
        # print()

count_targets_left = 0
for row in matrix:
    if 'x' in row:

        count_targets_left += 1

if count_targets_left == 0:
    print(f"Training completed! All {targets} targets hit.")
else:
    print(f"Training not completed! {count_targets_left} targets left.")

for t in targets_path:
    print(t)