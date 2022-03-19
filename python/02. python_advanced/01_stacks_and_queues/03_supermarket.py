input_name = input()
stack = []

while input_name != 'End':
    if input_name == 'Paid':
        for name in stack:
            print(name)
        stack = []
    else:
        stack.append(input_name)

    input_name = input()

print(f'{len(stack)} people remaining.')