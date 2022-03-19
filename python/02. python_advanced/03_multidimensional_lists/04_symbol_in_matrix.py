n = int(input())
matrix = []
is_occur = False

for i in range(n):
    text = input()
    matrix.append([x for x in text])

symbol = input()

for r in range(n):
    for c in range(n):
        if matrix[r][c] == symbol:
            print(f"{r, c}")
            is_occur = True
            break


if not is_occur:
    print(f"{symbol} does not occur in the matrix")
