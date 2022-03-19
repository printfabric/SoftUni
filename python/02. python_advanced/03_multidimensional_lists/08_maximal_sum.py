row, col = [int(x) for x in input().split()]
matrix = []
biggest_sum_row_index = 0
biggest_sum_col_index = 0
max_sum = -1000000

for i in range(row):
    matrix.append([int(x) for x in input().split()])

for r in range(0, row - 2):
    for c in range(0, col - 2):
        current_sum = matrix[r][c] + matrix[r][c + 1] + matrix[r][c + 2] + \
                      matrix[r + 1][c] + matrix[r + 1][c + 1] + matrix[r + 1][c + 2] + \
                      matrix[r + 2][c] + matrix[r + 2][c + 1] + matrix[r + 2][c + 2]

        if current_sum > max_sum:
            max_sum = current_sum
            biggest_sum_row_index = r
            biggest_sum_col_index = c

print(f"Sum = {max_sum}")

print(f"{matrix[biggest_sum_row_index][biggest_sum_col_index]} "
      f"{matrix[biggest_sum_row_index][biggest_sum_col_index + 1]} "
      f"{matrix[biggest_sum_row_index][biggest_sum_col_index + 2]}")

print(f"{matrix[biggest_sum_row_index + 1][biggest_sum_col_index]} "
      f"{matrix[biggest_sum_row_index + 1][biggest_sum_col_index + 1]} "
      f"{matrix[biggest_sum_row_index + 1][biggest_sum_col_index + 2]}")

print(f"{matrix[biggest_sum_row_index + 2][biggest_sum_col_index]} "
      f"{matrix[biggest_sum_row_index + 2][biggest_sum_col_index + 1]} "
      f"{matrix[biggest_sum_row_index + 2][biggest_sum_col_index + 2]}")

