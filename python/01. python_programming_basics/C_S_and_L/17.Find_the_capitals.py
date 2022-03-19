string = input()
indices = []

for ch in range(0, len(string)):
    if string[ch].isupper():
        indices.append(ch)
print(indices)