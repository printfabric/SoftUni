n = int(input())
matrix = []
result = 0

for r in range(0, n):
    matrix.append([int(x) for x in input().split()])


for r in range(0, n):
    for c in range(r, r + 1):
        result += matrix[r][c]

print(result)



