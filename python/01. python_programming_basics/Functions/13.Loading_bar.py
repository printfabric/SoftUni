num = int(input())


def loading(num):
    if num == 100:
        print('100% Complete!')
    else:
        percentage = int(num / 10)
        dots = int(10 - (num / 10))
        print(f'{num}% ' + '[' + ('%' * percentage) + ('.' * dots) + ']')
        print('Still loading...')

loading(num)
