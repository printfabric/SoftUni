function solve(r) {
    if (typeof r === 'number') {
        let result = Math.PI * (r ** 2); 
        console.log(result.toFixed(2));    
    } 
    else {
        console.log(`We can not calculate the circle area, because we receive a ${typeof r }.`)
    }
}

solve('5');