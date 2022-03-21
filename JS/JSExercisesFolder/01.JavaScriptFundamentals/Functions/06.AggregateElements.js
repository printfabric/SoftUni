function agrefateElements(input) {
  let firstSum = 0;
  let secondSum = 0;
  let concatenation = '';
  for (let i = 0; i < input.length; i++) {
    firstSum += input[i];
    secondSum += 1 / input[i];
    concatenation += input[i];
  }

  console.log(firstSum);
  console.log(secondSum);
  console.log(concatenation);
}

agrefateElements([2, 4, 8, 16]);