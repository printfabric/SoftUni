numbers = [int(x) for x in input().split()]
stack = []

for ch in numbers:
    stack.append(ch)

while len(stack) > 0:
    print(stack.pop(), end=' ')
