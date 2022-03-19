input_str = input()
s = [x for x in input_str]
stack = []

for ch in s:
    stack.append(ch)

while len(stack) > 0:
    print(stack.pop(), end='')