first_string = input().split(', ')
second_string = input().split(', ')
result = []

for i in range(len(first_string)):
    word = first_string[i]
    for j in range(len(second_string)):
        second_word = second_string[j]
        if word in second_word:
            result.append(word)
            break

print(result)
