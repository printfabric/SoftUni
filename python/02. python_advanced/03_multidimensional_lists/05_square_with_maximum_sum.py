row, col = [int(x) for x in input().split(", ")]
matrix = []
biggest_sum_row = 0
biggest_sum_col = 0
max_sum = -1000000

for i in range(row):
    matrix.append([int(x) for x in input().split(", ")])

for r in range(0, row - 1):
    for c in range(0, col - 1):
        current_sum = matrix[r][c] + matrix[r][c + 1] + \
                      matrix[r + 1][c] + matrix[r + 1][c + 1]
        if current_sum > max_sum:
            max_sum = current_sum
            biggest_sum_row = r
            biggest_sum_col = c

print(f"{matrix[biggest_sum_row][biggest_sum_col]} {matrix[biggest_sum_row][biggest_sum_col + 1]}")
print(f"{matrix[biggest_sum_row + 1][biggest_sum_col]} {matrix[biggest_sum_row + 1][biggest_sum_col + 1]}")
print(max_sum)