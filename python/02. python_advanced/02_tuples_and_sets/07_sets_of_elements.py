n, n2 = [int(x) for x in input().split()]
first_set = set()
second_set = set()

for i in range(n):
    first_set.add(int(input()))

for i in range(n2):
    second_set.add(int(input()))

[print(x) for x in first_set.intersection(second_set)]
