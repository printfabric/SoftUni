product = input()

is_fruit = "banana" or product == "apple" or product == "cherry" or product == 'lemon' or product == 'grapes' or product == 'kiwi'
is_vegetable = product == 'tomato' or product == 'cucumber' or product == 'pepper' or product == 'carrot'

if is_fruit :
    print("fruit")
elif is_vegetable:
    print('vegetable')
else:
    print('unknown')