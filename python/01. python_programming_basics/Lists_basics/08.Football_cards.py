input_string = input().split()
a = 11
b = 11
terminated = False
team_a_cards = []
team_b_cards = []

for i in range(len(input_string)):
    team = input_string[i].split('-')
    if a < 7 or b < 7:
        terminated = True
        break

    if team[0] == 'A':
        if team[1] in team_a_cards:
            pass
        else:
            a -= 1
            team_a_cards.append(team[1])
    elif team[0] == 'B':
        if team[1] in team_b_cards:
            pass
        else:
            b -= 1
            team_b_cards.append(team[1])

    if a < 7 or b < 7:
        terminated = True
        break

if terminated:
    print(f'Team A - {a}; Team B - {b}')
    print('Game was terminated')
else:
    print(f'Team A - {a}; Team B - {b}')


