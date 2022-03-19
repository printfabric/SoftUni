age_of_lili = int(input())
washing_machine_price = float(input())
single_toy_price = float(input())
lili_money = 0
temp = 0
lili_toys_count = 0

for i in range(1, age_of_lili + 1):
    if i % 2 == 0:
        temp += 10
        lili_money += temp
        lili_money -= 1
    else:
        lili_toys_count += 1

lili_money = lili_money + (single_toy_price * lili_toys_count)

if lili_money >= washing_machine_price:
    print(f'Yes! {lili_money - washing_machine_price:.2f}')
else:
    print(f'No! {washing_machine_price - lili_money:.2f}')