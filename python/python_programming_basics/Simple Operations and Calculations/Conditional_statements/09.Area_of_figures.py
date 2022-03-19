import math
figure_type = input()

if figure_type == "square":
    side_length = float(input())
    print(f"{side_length ** 2:.3f}")
elif figure_type == "rectangle":
    side_a_length = float(input())
    side_b_length = float(input())
    print(f"{(side_a_length * side_b_length):.3f}")
elif figure_type == "circle":
    radius = float(input())
    print(f"{((radius ** 2) * math.pi):.3f}")
elif figure_type == "triangle":
    side_length = float(input())
    height_length = float(input())
    print(f"{((side_length * height_length) / 2):.3f}")

