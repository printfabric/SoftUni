factor = int(input())
count = int(input())
num = factor
limit = True
counter = 0
ll = []

while limit:
    ll.append(num)
    num += factor
    counter += 1
    if counter >= count:
        limit = False

print(ll)