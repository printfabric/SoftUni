function attachEventsListeners() {
    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds'); 

    
    let daysBtn = document.getElementById('daysBtn');
    daysBtn.addEventListener('click', function () {
         convert(+days.value * 86400)
    });
    
    let hoursBtn = document.getElementById('hoursBtn');
    hoursBtn.addEventListener('click', function () {
         convert(+hours.value * 3600)
    });

    let minutesBtn = document.getElementById('minutesBtn');
    minutesBtn.addEventListener('click', function () {
         convert(+minutes.value * 60)
    });

    let secondsBtn = document.getElementById('secondsBtn');
    secondsBtn.addEventListener('click', function () {
         convert(+seconds.value)
    })


    function convert(sec = 0) {
        let day = sec / 86400;
        let hour = sec / 3600;
        let minute = sec / 60;

        days.value = day;
        hours.value = hour;
        minutes.value = minute;
        seconds.value = sec;
    }
}