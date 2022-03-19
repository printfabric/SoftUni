n = int(input())

for f in range(0, n):
    for s in range(0, n):
        for t in range(0, n):
            print(f'{chr(97 + f)}{chr(97 + s)}{chr(97 + t)}')