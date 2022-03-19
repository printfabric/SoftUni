first_string = input()
second_string = input()
third_string = first_string

for i in range(0, len(first_string)):
    first_string = second_string[:i] + first_string[i:]

    if third_string == first_string:
        pass
    else:
        print(first_string)

    third_string = first_string

    if first_string == second_string:
        break
