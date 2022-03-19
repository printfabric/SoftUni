from _collections import deque

row, col = [int(x) for x in input().split()]
input_string = input()
matrix = []
queue = deque()

for r in range(row):
    matrix.append([0] * col)

for i in range(len(input_string)):
    queue.append(input_string[i])

for r in range(row):
    if r % 2 == 0:
        for c in range(col):
            matrix[r][c] = queue[0]
            queue.append(queue.popleft())
    else:
        for c in range(col - 1, -1, -1):
            matrix[r][c] = queue[0]
            queue.append(queue.popleft())


for r in range(row):
    print(''.join(map(str, matrix[r])))