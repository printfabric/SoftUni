fireworks_effects = [int(x) for x in input().split(", ")]
explosive_power = [int(x) for x in input().split(", ")]

palm_fireworks = 0
willow_firework = 0
crossette_firework = 0

while True:

    if palm_fireworks >= 3 and willow_firework >= 3 and crossette_firework >= 3:
        break
    if len(fireworks_effects) <= 0 or len(explosive_power) <= 0:
        break

    current_effect = fireworks_effects[0]
    current_power = explosive_power[-1]

    if current_effect <= 0:
        fireworks_effects.pop(0)
    elif current_power <= 0:
        explosive_power = explosive_power[:-1]
    else:
        mixed_sum = fireworks_effects[0] + explosive_power[-1]

        if mixed_sum % 3 == 0 and mixed_sum % 5 != 0:
            palm_fireworks += 1
            fireworks_effects.pop(0)
            explosive_power = explosive_power[:-1]
        elif mixed_sum % 5 == 0 and mixed_sum % 3 != 0:
            willow_firework += 1
            fireworks_effects.pop(0)
            explosive_power = explosive_power[:-1]
        elif mixed_sum % 5 == 0 and mixed_sum % 3 == 0:
            crossette_firework += 1
            fireworks_effects.pop(0)
            explosive_power = explosive_power[:-1]
        else:
            fireworks_effects[0] -= 1
            fireworks_effects.append(fireworks_effects.pop(0))

if palm_fireworks >= 3 and willow_firework >= 3 and crossette_firework >= 3:
    print("Congrats! You made the perfect firework show!")
else:
    print("Sorry. You can't make the perfect firework show.")

if len(fireworks_effects) > 0:
    print(f"Firework Effects left: {', '.join([str(i) for i in fireworks_effects])}")
if len(explosive_power) > 0:
    print(f"Explosive Power left: {', '.join([str(i) for i in explosive_power])}")

print(f"Palm Fireworks: {palm_fireworks}")
print(f"Willow Fireworks: {willow_firework}")
print(f"Crossette Fireworks: {crossette_firework}")
