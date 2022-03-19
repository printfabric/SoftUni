single_string = input()
single_string = single_string.split()
numbers = []

for i in range(len(single_string)):
    if int(single_string[i]) < 0:
        numbers.append(abs(int(single_string[i])))
    else:
        numbers.append(int(single_string[i]) * - 1)

print(numbers)
