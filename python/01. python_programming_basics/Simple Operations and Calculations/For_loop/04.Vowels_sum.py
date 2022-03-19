word = input()
sum = 0

for i in range(len(word)):
    if word[i] == 'a':
        sum += 1
    elif word[i] == 'e':
        sum += 2
    elif word[i] == 'i':
        sum += 3
    elif word[i] == 'o':
        sum += 4
    elif word[i] == 'u':
        sum += 5

print(sum)