clothes = [int(x) for x in input().split()]
capacity = int(input())
stack = []
counter = 0
current_sum = 0

for x in clothes:
    stack.append(x)

while len(stack) > 0:
    current_sum += stack[-1]
    if capacity >= current_sum:
        stack.pop()
    else:
        counter += 1
        current_sum = 0

print(counter + 1)

