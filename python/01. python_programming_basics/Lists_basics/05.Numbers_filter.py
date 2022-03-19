n = int(input())
ll = []
second_list = []

for i in range(n):
    ll.append(int(input()))

command = input()

if command == 'even':
    for i in range(n):
        if ll[i] % 2 == 0:
            second_list.append(ll[i])
elif command == 'odd':
    for i in range(n):
        if ll[i] % 2 != 0:
            second_list.append(ll[i])
elif command == 'negative':
    for i in range(n):
        if ll[i] < 0:
            second_list.append(ll[i])
else:
    for i in range(n):
        if ll[i] >= 0:
            second_list.append(ll[i])

print(second_list)