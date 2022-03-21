function solve(firstChar, secondChar) {
  let start = undefined;
  let stop = undefined;
  if (firstChar.charCodeAt(0) < secondChar.charCodeAt(0)) {
    start = firstChar.charCodeAt(0);
    stop = secondChar.charCodeAt(0);
  } else {
    stop = firstChar.charCodeAt(0);
    start = secondChar.charCodeAt(0);
  }

  let arr = [];
  for (let i = start + 1; i < stop; i++) {
    arr.push(String.fromCharCode(i));
  }

  console.log(arr.join(' '));
}

solve('#', 'C');
