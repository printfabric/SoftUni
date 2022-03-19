n = int(input())

matrix = [[int(x) for x in input().split(', ')] for i in range(n)]

flat_matrix = [x for y in matrix for x in y]
print(flat_matrix)
