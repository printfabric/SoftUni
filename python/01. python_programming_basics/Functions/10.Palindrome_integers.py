nums = input().split(', ')


def is_palindrome(nums):
    for i in range(len(nums)):
        if nums[i] == nums[i][::-1]:
            print('True')
        else:
            print('False')


is_palindrome(nums)
