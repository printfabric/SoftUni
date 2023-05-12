function solve(num) {
    let digitsSum = 0;
    let value = num;

    while (value) {
        digitsSum += value % 10;
        value = Math.floor(value / 10);
    }

    let result = true;
    let first = num % 10;

    while (num) {

        if (num % 10 !== first) {
            result = false;
            
        } 
        num = Math.floor(num / 10);
    }

    console.log(result);
    console.log(digitsSum);
}

solve(2222222);