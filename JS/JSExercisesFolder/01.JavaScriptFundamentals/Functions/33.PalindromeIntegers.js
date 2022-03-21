function solve(arr) {
  let num = '';
  let temp = '';
  for (let i = 0; i < arr.length; i++) {
    temp = arr[i].toString();
    for (let j = temp.length - 1; j > -1; j--) {
      num += temp[j];
    }

    if (num === arr[i].toString()) {
      console.log('true');
    } else {
      console.log('false');
    }

    num = '';
  }
}

solve([123, 323, 421, 121]);
