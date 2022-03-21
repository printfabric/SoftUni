function solve(arr) {
  let nElement = Number(arr[arr.length - 1]);
  let result = [];
  for (let i = 0; i < arr.length - 1; i += nElement) {
    result.push(arr[i]);
  }

  console.log(result.join(' '));
}

solve(['1', '2', '3', '4', '5', '6']);
