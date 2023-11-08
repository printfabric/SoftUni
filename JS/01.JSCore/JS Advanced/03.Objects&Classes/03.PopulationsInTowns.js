function solve(input) {
    let data = input
        .map(row => row.split('<->')
        .map(x => x.trim()));

    let towns = {};

    data.forEach(row => {

        if (towns[row[0]]) {
            towns[row[0]] += Number(row[1]);
        }
        else {
            towns[row[0]] = Number(row[1]);
        }

    });
    
    for (const key in towns) {

        console.log(`${key} : ${towns[key]}`);
    }

}

solve(['Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']
);