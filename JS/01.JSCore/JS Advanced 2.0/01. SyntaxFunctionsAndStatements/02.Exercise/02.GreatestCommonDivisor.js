function solve(a, b) { 
    let divisor;

    for (let i = 1; i <= a && i <= b; i++) {

        if(a % i == 0 && b % i == 0) {

            divisor = i;
        }
    }

    console.log(divisor); 
} 

solve(1254, 458);