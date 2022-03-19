grade = float(input())

def grade_in_words(grade):
    result = None
    if 2.0 <= grade <= 2.99:
        result = 'Fail'
    elif 2.99 < grade <= 3.49:
        result = 'Poor'
    elif 3.49 < grade <= 4.49:
        result = 'Good'
    elif 4.49 < grade <= 5.49:
        result = 'Very Good'
    elif 5.49 < grade <= 6.00:
        result = 'Excellent'
    return result

print(grade_in_words(grade))