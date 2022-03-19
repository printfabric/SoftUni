nums = input().split(', ')
beggars = int(input())
ll = [0] * beggars
counter = 0

for i in range(0, len(nums), beggars):
    for j in range(0, beggars):
        counter += 1
        if counter > len(nums):
            pass
        else:
            ll[j] += int(nums[i+j])

print(ll)