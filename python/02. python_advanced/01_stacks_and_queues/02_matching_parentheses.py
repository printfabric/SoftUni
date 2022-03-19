input_str = input()
stack = []

for i in range(0, len(input_str)):
    if input_str[i] == '(':
        stack.append(i)
    elif input_str[i] == ')':
        start_index = stack.pop()
        end_index = i + 1
        print(input_str[start_index:end_index])
