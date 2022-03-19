town = input()
sales = float(input())
commission = 0
error = 0

if sales < 0:
    error += 1
elif town == "Sofia":
    if sales >= 0 and sales <= 500:
        commission += sales * 0.05
    elif sales > 500 and sales <= 1000:
        commission += sales * 0.07
    elif sales > 1000 and sales <= 10000:
        commission += sales * 0.08
    elif sales > 10000:
        commission += sales * 0.12
elif town == 'Varna':
    if sales >= 0 and sales <= 500:
        commission += sales * 0.045
    elif sales > 500 and sales <= 1000:
        commission += sales * 0.075
    elif sales > 1000 and sales <= 10000:
        commission += sales * 0.10
    elif sales > 10000:
        commission += sales * 0.13
elif town == 'Plovdiv':
    if sales >= 0 and sales <= 500:
        commission += sales * 0.055
    elif sales > 500 and sales <= 1000:
        commission += sales * 0.08
    elif sales > 1000 and sales <= 10000:
        commission += sales * 0.12
    elif sales > 10000:
        commission += sales * 0.145
else:
    error += 1

if error > 0:
    print('error')
else:
    print(f'{commission:.2f}')
