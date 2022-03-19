n = int(input())
people = set()

for x in range(n):
    name = input()
    people.add(name)

for person in people:
    print(person)