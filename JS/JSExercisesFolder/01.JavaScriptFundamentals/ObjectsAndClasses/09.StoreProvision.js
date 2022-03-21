function solve(firstArr, secondArr) {
  let storeSupplyArr = [];
  let product = {};
  let counter = 0;

  // function containsObject(obj, list) {
  //   var i;
  //   for (i = 0; i < list.length; i++) {
  //     if (list[i] === obj) {
  //       return true;
  //     }
  //   }

  //   return false;
  // }

  for (let i = 0; i < firstArr.length; i += 2) {
    product.name = firstArr[i];
    product.quantity = firstArr[i + 1];
    storeSupplyArr.push(product);
    product = {};
  }

  for (let i = 0; i < firstArr.length; i += 2) {
    if (storeSupplyArr.indexOf(secondArr[i]) === 1) {
      //console.log(storeSupplyArr.name.indexOf(secondArr[i]));
      //counter = counter + 1;
      //console.log(counter);
      storeSupplyArr[firstArr[i]] = firstArr[i + 1];
    } // else {
    //   product.name = firstArr[i];
    //   product.quantity = firstArr[i + 1];
    // }

    product = {};
    //console.log(storeSupplyArr);
  }

  for (let i = 0; i < storeSupplyArr.length; i++) {
    console.log(storeSupplyArr[i]);
  }

  console.log(storeSupplyArr.length);
}

solve(
  ['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'],
  ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30']
);
