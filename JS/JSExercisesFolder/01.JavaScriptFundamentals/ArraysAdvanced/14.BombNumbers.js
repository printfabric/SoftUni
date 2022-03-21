function solve(arr, bumbAndPower) {
  let bumb = bumbAndPower[0];
  let power = bumbAndPower[1];

  for (let i = 0; i < arr.length; i++) {
    if (bumb === arr[i]) {
      if (power > i) {
        arr.splice(0, i + power + 1);
      } else {
        arr.splice(i - power, power * 2 + 1);
      }

      i = 0;
    }
  }

  return console.log(arr.reduce((a, b) => a + b, 0));
}

solve([1, 2, 2, 4, 2, 2, 2, 9], [4, 2]);
