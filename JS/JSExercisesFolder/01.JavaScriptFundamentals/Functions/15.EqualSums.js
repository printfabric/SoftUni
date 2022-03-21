function solve(arr) {
  if (arr.length === 1) {
    console.log(0);
  } else {
    let isEqual = false;
    let temp = 0;
    for (let i = 0; i < arr.length; i++) {
      let arrFirstHalfSum = 0;
      let arrSecondHalfSum = 0;

      for (let j = 0; j < i; j++) {
        arrFirstHalfSum += arr[j];
      }

      for (let k = i + 1; k < arr.length; k++) {
        arrSecondHalfSum += arr[k];
      }

      if (arrFirstHalfSum === arrSecondHalfSum) {
        isEqual = true;
        temp = i;
      }
    }

    if (isEqual) {
      console.log(temp);
    } else {
      console.log('no');
    }
  }
}

solve([1, 2]);
