n = int(input())
matrix = []
sum_of_pimary_diagonal = 0
sum_of_opposite_diagonal = 0
for r in range(0, n):
    matrix.append([int(x) for x in input().split()])


for r in range(0, n):
    for c in range(r, r + 1):
        sum_of_pimary_diagonal += matrix[r][c]

for r in range(0, n):
    for c in range(n - 1 - r, n - r - 2, -1):
        sum_of_opposite_diagonal += matrix[r][c]

print(abs(sum_of_pimary_diagonal - sum_of_opposite_diagonal))
