function solve(fruit, weight, price) {
    let weightKg = weight / 1000;
    let money = weightKg * price;
    console.log(`I need $${money.toFixed(2)} to buy ${weightKg.toFixed(2)} kilograms ${fruit}.`)
}

solve('orange', 2500, 1.80);