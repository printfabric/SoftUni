size_a = int(input())
size_b = int(input())
command = input()
cake_size = size_a * size_b
taken_pieces = 0
no_more_cake = False

while command != 'STOP':
    command = int(command)
    taken_pieces += command

    if taken_pieces > cake_size:
        print(f'No more cake left! You need {taken_pieces - cake_size} pieces more.')
        no_more_cake = True
        break

    command = input()

if not no_more_cake:
    print(f'{cake_size - taken_pieces} pieces are left.')
