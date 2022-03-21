let input = [200, 'motorway'];
let limit = getLimit(input[1]);
let infraction = getInfraction(input[0], limit);
if (infraction) {
  console.log(infraction);
}

function getLimit(zone) {
  if (zone === 'motorway') {
    return 130;
  } else if (zone === 'interstate') {
    return 90;
  } else if (zone === 'city') {
    return 50;
  } else if (zone === 'residential') {
    return 20;
  }
}

function getInfraction(speed, limit) {
  let overSpeed = speed - limit;
  if (overSpeed <= 0) {
    return false;
  } else {
    if (overSpeed <= 20) {
      return 'speeding';
    } else if (overSpeed > 20 && overSpeed <= 40) {
      return 'excessive speeding';
    } else if (overSpeed > 40) {
      return 'reckless driving';
    }
  }
}
