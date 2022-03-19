n = int(input())
current_sum = 0
row = 1
odd_set = set()
even_set = set()

for _ in range(n):
    player = input()

    for ch in player:
        current_sum += ord(ch)

    temp = int(current_sum / row)

    if temp % 2 != 0:
        odd_set.add(temp)
    else:
        even_set.add(temp)

    row += 1
    current_sum = 0

odd_set_sum = sum(odd_set)
even_set_sum = sum(even_set)

if odd_set_sum == even_set_sum:
    l = list(odd_set.union(even_set))
    l = [str(x) for x in l]
    print(', '.join(l))

if odd_set_sum > even_set_sum:
    l = list(odd_set.difference(even_set))
    l = [str(x) for x in l]
    print(', '.join(l))

if odd_set_sum < even_set_sum:
    l = list(even_set.symmetric_difference(odd_set))
    l = [str(x) for x in l]
    print(', '.join(l))
