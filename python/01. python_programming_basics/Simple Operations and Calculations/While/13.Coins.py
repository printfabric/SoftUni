changeBills = float(input())
coins = 0
change = (int)(changeBills * 100)

coins = (change / 200)
change = (change % 200)

coins += (change / 100)
change = (change % 100)

coins += (change / 50)
change = (change % 50)

coins += (change / 20)
change = (change % 20)

coins += (change / 10)
change = (change % 10)

coins += (change / 5)
change = (change % 5)

coins += (change / 2)
change = (change % 2)

coins += change

print(coins)