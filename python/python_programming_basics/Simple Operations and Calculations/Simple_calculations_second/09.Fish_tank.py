length = int(input())
width = int(input())
height = int(input())
percentage_of_volume = float(input())

percent = percentage_of_volume * 0.01
needed_liters = ((length * width * height) * 0.001) * (1 - percent)

print("%.3f" % needed_liters)
