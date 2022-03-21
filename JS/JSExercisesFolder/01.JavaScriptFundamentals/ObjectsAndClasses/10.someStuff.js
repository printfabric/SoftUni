function solve(arr) {
  let town = {};
  let towns = [];

  for (let i = 0; i < arr.length; i++) {
    let splittedInput = arr[i].split(' | ');
    town.town = splittedInput[0];
    town.latitude = parseFloat(splittedInput[1]).toFixed(2);
    town.longitude = parseFloat(splittedInput[2]).toFixed(2);
    towns.push(town);
    town = {};
  }

  for (let i = 0; i < towns.length; i++) {
    console.log(towns[i]);
  }
}

solve(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);