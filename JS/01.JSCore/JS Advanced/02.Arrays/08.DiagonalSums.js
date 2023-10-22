function solve(matrix) {
    let mainDiagonal = 0;
    let secondaryDiagonal = 0 ;
    let result = '';

    for (let i = 0; i < matrix.length; i++) {
        for (let j = i; j < i + 1; j++) {
            mainDiagonal += matrix[i][j];
        }
    }

    result += mainDiagonal.toString() + ' ';

    for (let i = 0; i < matrix.length; i++) {
        for (let j = matrix.length - i - 1; j > matrix.length - i - 2; j--) {
            secondaryDiagonal += matrix[i][j];
        }
    }

    result += secondaryDiagonal.toString() + ' ';
    console.log(result);
}

solve([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]
   );