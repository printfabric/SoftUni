/* eslint-disable no-plusplus */
function triangleOfStars(input) {
  for (let i = 0; i < input; i++) {
    let row = '';
    for (let j = 0; j < input; j++) {
      row += '*';
    }
    console.log(row);
  }

  for (let i = input; i > 0; i--) {
    let row = '';
    for (let j = i; j > 0; j--) {
      row += '*';
    }
    console.log(row);
  }
}

triangleOfStars(5);