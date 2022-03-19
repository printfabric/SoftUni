person_info = input().split('-')
phonebook = {}

while not person_info[0].isdigit():
    phonebook[person_info[0]] = person_info[1]
    person_info = input().split('-')

for i in range(int(person_info[0])):
    person = input()

    if person in phonebook:
        print(f"{person} -> {phonebook[person]}")
    else:
        print(f"Contact {person} does not exist.")
