function solve(first, second, third) {
    let sum = first.length + second.length + third.length;
    let average = sum / 3;

    console.log(sum);
    console.log(Math.floor(average));
}

solve('chocolate', 'ice cream', 'cake');
