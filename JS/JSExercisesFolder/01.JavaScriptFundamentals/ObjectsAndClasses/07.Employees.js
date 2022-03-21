function solve(arr) {
  let employee = {};
  let employees = [];
  for (let i = 0; i < arr.length; i++) {
    employee.name = arr[i];
    employee.personalNum = arr[i].length;
    employees.push(employee);
    employee = {};
  }

  for (let i = 0; i < employees.length; i++) {
    console.log(
      `Name: ${employees[i].name} -- Personal Number: ${employees[i].personalNum}`
    );
  }
}

solve([
  'Silas Butler',
  'Adnaan Buckley',
  'Juan Peterson',
  'Brendan Villarreal',
]);
