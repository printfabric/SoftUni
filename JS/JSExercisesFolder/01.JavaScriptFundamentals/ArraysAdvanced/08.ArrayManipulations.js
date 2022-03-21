function solve(arr) {
  let nums = arr[0].split(' ');

  for (let i = 1; i < arr.length; i++) {
    let split = arr[i].split(' ');
    let operation = split[0];
    let number = split[1];
    if (operation === 'Insert') {
      nums.splice(split[2], 0, split[1]);
    } else if (operation === 'Add') {
      nums.push(number);
    } else if (operation === 'Remove') {
      nums = nums.filter((e) => e !== number);
    } else if (operation === 'RemoveAt') {
      nums.splice(number, 1);
    }
  }

  return nums.join(' ');
}

solve(['4 19 2 53 6 43', 'Add 3', 'Remove 2', 'RemoveAt 1', 'Insert 8 3']);
