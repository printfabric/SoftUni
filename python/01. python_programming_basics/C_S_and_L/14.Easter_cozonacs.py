budget = float(input())
kg_flour_price = float(input())
eggs_price = kg_flour_price * 0.75
milk_price = (kg_flour_price * 1.25) / 4
one_batch = kg_flour_price + eggs_price + milk_price
cosonacs = 0
money = True
eggs = 0

while money:
    if budget < one_batch:
        money = False
    else:
        cosonacs += 1
        eggs += 3
        budget -= one_batch

    if cosonacs % 3 == 0:
        eggs = eggs - (cosonacs - 2)
        if eggs < 0:
            eggs = 0
print(f'You made {cosonacs} cozonacs! Now you have {eggs} eggs and {budget:.2f}BGN left.')