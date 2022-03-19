n = int(input())

matrix = []

for _ in range(n):
    list = [int(x) for x in input().split(', ')]
    matrix.append([int(x) for x in list if x % 2 == 0])

print(matrix)