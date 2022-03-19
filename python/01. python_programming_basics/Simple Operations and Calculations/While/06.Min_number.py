import sys

n = int(input())
min = sys.maxsize

for i in range(n):
    num = int(input())
    if num < min:
        min = num

print(min)