import sys

n = int(input())
max = - sys.maxsize - 1

for i in range(n):
    num = int(input())
    if num > max:
        max = num

print(max)