function palindrome(input) {
  if (
    input
    .split('')
    .reverse()
    .join('') === input
  ) {
    console.log('true');
  } else {
    console.log('false')
  }
}

palindrome('abba')