function solve(num) {
    num = num.toString();
    let sum = +num[0];
    let counter = 0;

    for (let i = 1; i < num.length; i++) {
        let firstNum = +num[i - 1];
        let secondNum = +num[i];
        sum += secondNum;
        if (firstNum !== secondNum) {
            counter++;
        }

    }

    if (counter < 1) {
        console.log(true);
        console.log(sum);
    } else {
        console.log(false);
        console.log(sum);
    }

}

solve(1234);