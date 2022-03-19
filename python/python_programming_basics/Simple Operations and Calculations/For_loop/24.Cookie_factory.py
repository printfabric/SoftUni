batches = int(input())
flour = eggs = sugar = False
ingredient = None
counter = 0

while batches:
    while ingredient != 'Bake!':
        ingredient = input()
        if ingredient == 'flour':
            flour = True
        elif ingredient == 'eggs':
            eggs = True
        elif ingredient == 'sugar':
            sugar = True

    if flour and eggs and sugar:
        print(f'Baking batch number {counter + 1}... ')
        counter += 1
        batches -= 1
    else:
        print(f'The batter should contain flour, eggs and sugar!')
    ingredient = None