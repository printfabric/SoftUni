txt = input()
sheep_list = txt.split(", ")

if sheep_list[len(sheep_list) - 1] == 'wolf':
    print('Please go away and stop eating my sheep')
elif sheep_list[0] == 'wolf':
        print(f'Oi! Sheep number 5! You are about to be eaten by a wolf!')
else:
        for i in range(0, len(sheep_list)):
            if sheep_list[i] == 'wolf':
                print(f'Oi! Sheep number {len(sheep_list) - (i + 1)}! You are about to be eaten by a wolf!')
                break