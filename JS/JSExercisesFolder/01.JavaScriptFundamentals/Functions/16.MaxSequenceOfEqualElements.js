function solve(arr) {
  let maxArr = [];
  let tempArr = [];

  for (let i = 0; i < arr.length; i++) {
    tempArr.push(arr[i]);
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[i] !== arr[j]) {
        break;
      } else {
        tempArr.push(arr[j]);
      }
    }

    if (tempArr.length > maxArr.length) {
      maxArr = [];
      maxArr = tempArr;
    }

    tempArr = [];
  }

  console.log(maxArr.join(' '));
}

solve([0, 1, 1, 5, 2, 2, 6, 3, 3]);
