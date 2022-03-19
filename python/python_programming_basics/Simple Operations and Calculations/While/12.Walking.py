goal_steps = 0

while True:
    steps = input()

    if steps != 'Going home':
        goal_steps += int(steps)
        if goal_steps >= 10000:
            print('Goal reached! Good job!')
            break
    elif steps == 'Going home':
        steps = input()
        goal_steps += int(steps)

        if goal_steps >= 10000:
            print('Goal reached! Good job!')
            break
        else:
            print(f'{10000 - goal_steps} more steps to reach goal.')
            break


