name = input()
sum = 0
winner = 0
winner_name = None

while name != 'STOP':
    length = len(name)
    for i in range(0, length):
        sum += ord(name[i])

    if winner < sum:
        winner = sum
        winner_name = name
    sum = 0
    name = input()
print(f'Winner is {winner_name} - {winner}!')