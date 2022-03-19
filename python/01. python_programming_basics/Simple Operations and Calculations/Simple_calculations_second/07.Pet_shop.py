dogs_num = int(input())
other_animals_num = int(input())

dog_food = 2.5 * dogs_num
other_food = 4 * other_animals_num
sum_off_food = "%.2f" % (dog_food + other_food)

print(f"{sum_off_food} lv.")