todo = [None] * 10

while True:
    chores = input().split('-')
    if chores[0] == 'End':
        break
    index = int(chores[0])
    chore = chores[1]
    todo.insert(index, chore)

todo = [x for x in todo if x]
print(todo)