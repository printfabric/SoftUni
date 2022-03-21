function solve(arr) {
  class Cat {
    constructor(name, age) {
      this.name = name;
      this.age = age;
    }
  }

  let cats = [];

  for (let i = 0; i < arr.length; i++) {
    let catData = arr[i].split(' ');
    let name = catData[0];
    let age = catData[1];
    cats.push(new Cat(name, age));
  }

  for (let i = 0; i < cats.length; i++) {
    let entries = Object.entries(cats[i]);
    console.log(`${entries[0][1]}, age ${entries[1][1]} says Meow`);
  }
}

solve(['Mellow 2', 'Tom 5']);
