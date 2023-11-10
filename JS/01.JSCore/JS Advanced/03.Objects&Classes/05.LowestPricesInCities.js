function solve(input) {

    let products = [];
    let data = input.map(row => row.split('|').map(x => x.trim()));

    data.forEach(row => {
        let product = {};
        
        if (!products.find(x => x.productName === row[1])) {
            product.productName = row[1];
            product.price = +row[2];
            product.town = row[0];
            
            products.push(product);
        }
        else {
            let obj = products.find(x => x.price > +row[2] && x.productName === row[1]);

            if (obj) {
                obj.productName = row[1];
                obj.price = +row[2];
                obj.town = row[0];
            }

        }
        
    });

    for (const key in products) {
        console.log(`${products[key].productName} -> ${products[key].price} (${products[key].town})`);
    }
    
}

solve(['Sample Town | Sample Product | 1000', 'Sample Town | Sample Product | 11', 'Sample Town | Orange | 2', 'Sample Town | Peach | 1',
 'Sofia | Orange | 3', 'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
);