year = int(input()) + 1
year = str(year)
happy_year = False

while not happy_year:
    if len(year) == 4 \
            and year[0] != year[1] \
            and year[0] != year[2] \
            and year[0] != year[3] \
            and year[1] != year[2] \
            and year[1] != year[3] \
            and year[2] != year[3]:
        happy_year = True
    elif len(year) == 3 \
            and year[0] != year[1] \
            and year[0] != year[2] \
            and year[1] != year[2]:
        happy_year = True
    else:
        year = int(year)
        year += 1
        year = str(year)
print(year)

