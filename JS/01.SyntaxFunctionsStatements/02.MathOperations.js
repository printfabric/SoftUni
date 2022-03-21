function solve(operand1, operand2, operator) {
    let sum = 0;
    if (operator === '+') {
        sum = operand1 + operand2
    } 
    else if (operator === '-') {
        sum = operand1 - operand2
    } 
    else if (operator === '*') {
        sum = operand1 * operand2
    } 
    else if (operator === '/') {
        sum = operand1 / operand2
    } 
    else if (operator === '%') {
        sum = operand1 % operand2
    } 
    else if (operator === '**') {
        sum = operand1 ** operand2
    }

    console.log(sum);
}

solve(5, 6, '+');