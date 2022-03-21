function solve(arr, num) {
  let result = [];
  for (let i = 0; i < arr.length; i++) {
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[i] + arr[j] === num) {
        let pair = arr[i] + ' ' + arr[j];
        if (!result.includes(pair)) {
          result.push(pair);
        }
      }
    }
  }

  console.log(result.join('\n'));
}

solve([1, 2, 3, 4, 5, 6], 6);
