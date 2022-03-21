function solve(matrix) {
    let maxNumber = Number.MIN_VALUE;
    
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            let currentNum= matrix[i][j];
            if (currentNum > maxNumber) {
                maxNumber = currentNum;
            }
        }
        
    }

    console.log(maxNumber);
}

solve([[20, 50, 10],
    [8, 33, 145]]
   );