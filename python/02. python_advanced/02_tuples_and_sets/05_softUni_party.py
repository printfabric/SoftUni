n = int(input())
people = set()

for x in range(n):
    res_code = input()
    people.add(res_code)

came = input()
while came != 'END':
    people.discard(came)
    came = input()

people = sorted(people)
print(len(people))

for code in people:
    print(code)
