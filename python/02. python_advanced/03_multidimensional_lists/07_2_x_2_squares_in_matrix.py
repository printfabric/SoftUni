row, col = [int(x) for x in input().split()]
matrix = []
counter = 0

for i in range(row):
    matrix.append([x for x in input().split()])

for r in range(0, row - 1):
    for c in range(0, col - 1):
        equal = matrix[r][c] == matrix[r][c + 1] == \
                      matrix[r + 1][c] == matrix[r + 1][c + 1]
        if equal:
            counter += 1

print(counter)