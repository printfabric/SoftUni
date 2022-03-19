n = int(input())
stack = []

for i in range(n):
    queri = input().split()

    if queri[0] == '1':
        stack.append(int(queri[1]))
    elif queri[0] == '2':
        if stack:
            stack.pop()
    elif queri[0] == '3':
        print(max(stack))
    elif queri[0] == '4':
        print(min(stack))

stack = [str(n) for n in stack]
stack.reverse()

separator = ', '
print(separator.join(stack))
