free_space_width  = int(input())
free_space_length  = int(input())
free_space_height  = int(input())
command = input()
total_free_space = free_space_height * free_space_length * free_space_width
occupied_space = 0

while command != 'Done':
    occupied_space += int(command)
    if occupied_space > total_free_space:
        print(f'No more free space! You need {occupied_space - total_free_space} Cubic meters more.')
        break
    command = input()

if command == 'Done':
    print(f'{total_free_space - occupied_space} Cubic meters left.')



