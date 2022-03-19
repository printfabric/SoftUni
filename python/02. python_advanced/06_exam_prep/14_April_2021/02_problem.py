first_player, second_player = input().split(", ")
first_player_scores = 501
second_player_scores = 501
first_player_throws = 0
second_player_throws = 0
matrix = []
counter = 0
winner = False

for i in range(7):
    matrix.append([x for x in input().split(' ')])

while winner == False:
    coordinates_info = input()
    coordinates_info = coordinates_info[1:-1]
    coordinates = [int(x) for x in coordinates_info.split(", ")]

    if coordinates[0] < 7 and coordinates[1] < 7 and coordinates[0] >= 0 and coordinates[1] >= 0:
        if counter % 2 == 0:
            first_player_throws += 1

            if matrix[coordinates[0]][coordinates[1]] == 'B':
                winner = True
                counter += 1
                break
            elif matrix[coordinates[0]][coordinates[1]] == 'D':
                first_player_scores -= (int(matrix[coordinates[0]][0]) + int(matrix[coordinates[0]][-1]) +
                                        int(matrix[0][coordinates[1]]) + int(matrix[6][coordinates[1]])) * 2
            elif matrix[coordinates[0]][coordinates[1]] == 'T':
                first_player_scores -= (int(matrix[coordinates[0]][0]) + int(matrix[coordinates[0]][-1]) +
                                        int(matrix[0][coordinates[1]]) + int(matrix[6][coordinates[1]])) * 3
            else:
                first_player_scores -= int(matrix[coordinates[0]][coordinates[1]])
        else:
            second_player_throws += 1

            if matrix[coordinates[0]][coordinates[1]] == 'B':
                winner = True
                counter += 1
                break
            elif matrix[coordinates[0]][coordinates[1]] == 'D':
                second_player_scores -= (int(matrix[coordinates[0]][0]) + int(matrix[coordinates[0]][-1]) +
                                        int(matrix[0][coordinates[1]]) + int(matrix[6][coordinates[1]])) * 2
            elif matrix[coordinates[0]][coordinates[1]] == 'T':
                second_player_scores -= (int(matrix[coordinates[0]][0]) + int(matrix[coordinates[0]][-1]) +
                                        int(matrix[0][coordinates[1]]) + int(matrix[6][coordinates[1]])) * 3
            else:
                second_player_scores -= int(matrix[coordinates[0]][coordinates[1]])

    counter += 1

    if first_player_scores < 1:
        winner = True
        break
    elif second_player_scores < 1:
        winner = True
        break


if counter % 2 != 0:
    print(f"{first_player} won the game with {first_player_throws} throws!")
else:
    print(f"{second_player} won the game with {second_player_throws} throws!")
