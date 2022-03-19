quantity = int(input())
days = int(input())

ornament_set = 2
tree_skirt = 5
tree_garlands = 3
tree_lights = 15
tottal_cost = 0
christmas_spirit = 0

for day in range(1, days + 1):
    if day % 11 == 0:
        quantity += 2
    if day % 2 == 0:
        tottal_cost += (2 * quantity)
        christmas_spirit += 5
    elif day % 3 == 0:
        tottal_cost += ((5 * quantity) + (3 * quantity))
        christmas_spirit += 13
        christmas_spirit += 30
    elif day % 5 == 0:
        tottal_cost += (15 * quantity)
        christmas_spirit += 15
    if day % 10 == 0:
        if days == 10:
            christmas_spirit -= 30
            tottal_cost -= (tree_skirt - tree_garlands - tree_lights)
        else:
            christmas_spirit -= 20
        tottal_cost -= (tree_skirt - tree_garlands - tree_lights)

print(tottal_cost)
print(christmas_spirit)