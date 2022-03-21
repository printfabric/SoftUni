function solve(password) {
  let valid = true;
  let digits = 0;
  let numsAndDigits = true;
  if (password.length < 6 || password.length > 10) {
    valid = false;
    console.log('Password must be between 6 and 10 characters');
  }

  for (let i = 0; i < password.length; i++) {
    if (
      password[i].charCodeAt(0) <= 47 ||
      (password[i].charCodeAt(0) > 57 && password[i].charCodeAt(0) < 65) ||
      (password[i].charCodeAt(0) > 90 && password[i].charCodeAt(0) < 97) ||
      password[i].charCodeAt(0) > 122
    ) {
      valid = false;
      numsAndDigits = false;
    }

    if (password[i].charCodeAt(0) > 47 && password[i].charCodeAt(0) < 58) {
      digits++;
    }
  }

  if (numsAndDigits === false) {
    console.log('Password must consist only of letters and digits');
  }

  if (digits < 3) {
    console.log('Password must have at least 2 digits');
    valid = false;
  }

  if (valid === true) {
    console.log('Password is valid');
  }
}

solve('Pa$s$s');
