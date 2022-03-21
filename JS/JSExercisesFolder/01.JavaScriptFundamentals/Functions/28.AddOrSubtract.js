function solve(arr) {
  let originalArrSum = 0;
  let modArrSum = 0;
  for (let i = 0; i < arr.length; i++) {
    let num = arr[i];
    originalArrSum += num;
    if (num % 2 === 0) {
      arr[i] = num + i;
    } else {
      arr[i] = num - i;
    }

    modArrSum += arr[i];
  }

  console.log(arr);
  console.log(originalArrSum);
  console.log(modArrSum);
}

solve([5, 15, 23, 56, 35]);
