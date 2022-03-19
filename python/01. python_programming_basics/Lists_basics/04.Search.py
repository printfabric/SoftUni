n = int(input())
word = input()
ll = []
second_list = []

for i in range(n):
    ll.append(input())

print(ll)
for i in range(n):
    if word in ll[i]:
        second_list.append(ll[i])

print(second_list)