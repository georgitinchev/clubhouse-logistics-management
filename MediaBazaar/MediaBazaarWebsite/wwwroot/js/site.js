function generateCalendar(year, month) {
    const calendarHeader = document.getElementById('calendar-header');
    const calendarElement = document.getElementById('calendar');
    const monthYearContainer = document.getElementById('calendar-month-year');
    calendarHeader.innerHTML = '';
    calendarElement.innerHTML = '';
    monthYearContainer.innerHTML = '';

    const weekDays = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];
    const slotNames = ['Morning', 'Afternoon', 'Evening'];

    const firstDay = new Date(year, month, 1);
    const lastDay = new Date(year, month + 1, 0);

    weekDays.forEach(day => {
        const headerCell = document.createElement('div');
        headerCell.textContent = day;
        headerCell.classList.add('day-header', 'weekday');
        calendarHeader.appendChild(headerCell);
    });

    const monthYearHeader = document.createElement('h2');
    monthYearHeader.textContent = `${firstDay.toLocaleString('default', { month: 'long' })} ${year}`;
    monthYearContainer.appendChild(monthYearHeader);

    for (let i = 1; i <= lastDay.getDate(); i++) {
        const dayElement = document.createElement('div');
        dayElement.classList.add('day');

        const dayNumber = document.createElement('div');
        dayNumber.textContent = i;
        dayNumber.classList.add('day-header');
        dayElement.appendChild(dayNumber);

        for (let j = 0; j < 3; j++) {
            const slot = document.createElement('div');
            slot.classList.add('slot');
            slot.textContent = slotNames[j];
            slot.setAttribute('data-date', `${year}-${month + 1}-${i}`);
            slot.setAttribute('data-timeslot', j);
            slot.addEventListener('click', reserveSlot);
            dayElement.appendChild(slot);
        }

        calendarElement.appendChild(dayElement);
    }
}

function reserveSlot(event) {
    const slot = event.target;
    const dayElement = slot.parentNode;
    const slots = Array.from(dayElement.getElementsByClassName('slot'));
    const index = slots.indexOf(slot);

    if (slot.classList.contains('reserved')) {
        slot.classList.remove('reserved');
    } else {
        slots.forEach((otherSlot, otherIndex) => {
            if (otherIndex !== index - 1 && otherIndex !== index + 1) {
                otherSlot.classList.remove('reserved');
            }
        });
        slot.classList.add('reserved');
    }
}

function getWeekNumber(d) {
    d = new Date(Date.UTC(d.getFullYear(), d.getMonth(), d.getDate()));
    d.setUTCDate(d.getUTCDate() + 4 - (d.getUTCDay() || 7));
    const yearStart = new Date(Date.UTC(d.getUTCFullYear(), 0, 1));
    const weekNo = Math.ceil((((d - yearStart) / 86400000) + 1) / 7);
    return weekNo;
}

function AvailabilitySlotDTO(contractID, slotID, timeSlotID, weekDayID, weekNr, month) {
    this.ContractID = contractID;
    this.Id = slotID;
    this.TimeSlotID = timeSlotID;
    this.WeekDayID = weekDayID;
    this.WeekNr = weekNr;
    this.Month = month;
}

document.getElementById('submit-availability').addEventListener('click', function () {
    const reservedSlots = document.querySelectorAll('.slot.reserved');
    const availabilitySlots = Array.from(reservedSlots).map(slot => {
        const date = new Date(slot.getAttribute('data-date'));
        const weekNr = getWeekNumber(date);
        const month = Math.ceil(weekNr / 4.34524);
        const timeSlotID = slot.getAttribute('data-timeslot');
        return new AvailabilitySlotDTO(contractID, slotID, timeSlotID, date.getDay(), weekNr, month);
    });

    // adding the code to send the availabilitySlots to the backend below this line

});

function prevMonth() {
    currentDate.setMonth(currentDate.getMonth() - 1);
    if (currentDate.getMonth() === 11) {
        currentDate.setFullYear(currentDate.getFullYear());
    }
    generateCalendar(currentDate.getFullYear(), currentDate.getMonth());
}

function nextMonth() {
    currentDate.setMonth(currentDate.getMonth() + 1);
    if (currentDate.getMonth() === 0) {
        currentDate.setFullYear(currentDate.getFullYear());
    }
    generateCalendar(currentDate.getFullYear(), currentDate.getMonth());
}

const currentDate = new Date();
generateCalendar(currentDate.getFullYear(), currentDate.getMonth());

document.getElementById('prev-month').addEventListener('click', prevMonth);
document.getElementById('next-month').addEventListener('click', nextMonth);
