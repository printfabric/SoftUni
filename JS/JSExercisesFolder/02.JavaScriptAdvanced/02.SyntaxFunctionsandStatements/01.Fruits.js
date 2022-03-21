function solve(steps, footprint, speed) {
    //let time = ((steps * footprint) / speed) * 60);
    let hours;
    let minutes = (((steps * footprint) / 1000) / speed) * 60;
    if (minutes > 60) {
        hours = minutes / 60;
        hours = parseInt(hours, 10);
    }

    console.log(hours)
}

solve(4000, 0.60, 5);