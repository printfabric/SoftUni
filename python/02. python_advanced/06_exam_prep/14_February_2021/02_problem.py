import math

field_size = int(input())
matrix = []
player_position = []
out_of_range = False
coins = 0
player_path = []

for i in range(field_size):
    temp = [x for x in input().split(' ')]
    matrix.append(temp)
    for j in range(len(temp)):
        if temp[j] == "P":
            player_position.append(i)
            player_position.append(j)

while coins < 100:
    command = input()
    if command == "up":
        if player_position[0] <= 0:
            out_of_range = True
            break
        else:
            if matrix[player_position[0] - 1][player_position[1]] == "X":
                out_of_range = True
                break
            else:
                coins += int(matrix[player_position[0] - 1][player_position[1]])
                player_position[0] -= 1
                player_path.append(player_position[:])
    elif command == "down":
        if player_position[0] >= field_size - 1:
            out_of_range = True
            break
        else:
            if matrix[player_position[0] + 1][player_position[1]] == "X":
                out_of_range = True
                break
            else:
                coins += int(matrix[player_position[0] + 1][player_position[1]])
                player_position[0] += 1
                player_path.append(player_position[:])
    elif command == "left":
        if player_position[1] <= 0:
            out_of_range = True
            break
        else:
            if matrix[player_position[0]][player_position[1] - 1] == "X":
                out_of_range = True
                break
            else:
                coins += int(matrix[player_position[0]][player_position[1] - 1])
                player_position[1] -= 1
                player_path.append(player_position[:])
    elif command == "right":
        if player_position[1] >= field_size - 1:
            out_of_range = True
            break
        else:
            if matrix[player_position[0]][player_position[1] + 1] == "X":
                out_of_range = True
                break
            else:
                coins += int(matrix[player_position[0]][player_position[1] + 1])
                player_position[1] += 1
                player_path.append(player_position[:])


if out_of_range:
    coins = math.floor(coins * 0.5)
    print(f"Game over! You've collected {coins} coins.")
else:
    if coins >= 100:
            print(f"You won! You've collected {coins} coins.")
    else:
            print(f"Game over! You've collected {coins} coins.")

print("Your path:")
for pos in player_path:
    print(pos)