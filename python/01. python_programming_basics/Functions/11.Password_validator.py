import re

password = input()


def is_pass_valid(password):
    valid = True
    if not 5 < len(password) < 11:
        valid = False
        print('Password must be between 6 and 10 characters')
    if not re.match("^[A-Za-z0-9_-]*$", password):
        valid = False
        print('Password must consist only of letters and digits')
    if sum(c.isdigit() for c in password) < 2:
        valid = False
        print('Password must have at least 2 digits')
    if valid:
        print('Password is valid')


is_pass_valid(password)
