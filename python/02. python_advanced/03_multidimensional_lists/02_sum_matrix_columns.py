row, col = [int(x) for x in input().split(", ")]
matrix = []

for i in range(row):
    matrix.append([int(x) for x in input().split(" ")])

current_sum = 0

for c in range(0, col):
    for r in range(0, row):
        current_sum += (matrix[r][c])
    print(current_sum)
    current_sum = 0
