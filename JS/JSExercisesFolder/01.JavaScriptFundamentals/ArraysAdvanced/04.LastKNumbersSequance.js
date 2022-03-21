function solve(n, k) {
  let arr = [];
  let temp = 0;
  arr.push(1);
  for (let i = 0; i < n - 1; i++) {
    temp = 0;
    for (let j = 0; j < k; j++) {
      let index = i - j;
      if (index >= 0) {
        temp += arr[index];
      }
    }

    arr.push(temp);
  }

  console.log(arr.join(' '));
}

solve(8, 2);
