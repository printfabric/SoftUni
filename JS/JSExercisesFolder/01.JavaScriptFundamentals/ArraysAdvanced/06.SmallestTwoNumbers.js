function solve(arr) {
  let min = Number.MAX_VALUE;
  let secondMin = Number.MAX_VALUE;

  for (let i = 0; i < arr.length; i++) {
    if (arr[i] < min) {
      min = arr[i];
    }

    if (arr[i] < secondMin && arr[i] > min) {
      secondMin = arr[i];
    }
  }

  console.log(`${min} ${secondMin}`);
}

solve([3, 0, 10, 4, 7, 3]);
