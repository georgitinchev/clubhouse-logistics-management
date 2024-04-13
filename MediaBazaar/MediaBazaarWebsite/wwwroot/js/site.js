// Function to generate the calendar
function generateCalendar(year, month) {
    const calendarHeader = document.getElementById('calendar-header');
    const calendarElement = document.getElementById('calendar');
    const monthYearContainer = document.getElementById('calendar-month-year');
    calendarHeader.innerHTML = '';
    calendarElement.innerHTML = '';
    monthYearContainer.innerHTML = '';

    // Array of week days starting from Monday
    const weekDays = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];

    // Get the first day and last day of the month
    const firstDay = new Date(year, month, 1);
    const lastDay = new Date(year, month + 1, 0);

    // Create header row with weekday names
    weekDays.forEach(day => {
        const headerCell = document.createElement('div');
        headerCell.textContent = day;
        headerCell.classList.add('day-header', 'weekday');
        calendarHeader.appendChild(headerCell);
    });

    // Create h2 element with month and year
    const monthYearHeader = document.createElement('h2');
    monthYearHeader.textContent = `${firstDay.toLocaleString('default', { month: 'long' })} ${year}`;
    monthYearContainer.appendChild(monthYearHeader);

    // Fill in the calendar with slots for each day
    for (let i = 1; i <= lastDay.getDate(); i++) {
        const dayElement = document.createElement('div');
        dayElement.classList.add('day');

        // Add day number
        const dayNumber = document.createElement('div');
        dayNumber.textContent = i;
        dayNumber.classList.add('day-header');
        dayElement.appendChild(dayNumber);

        // Add three slots for each day
        for (let j = 0; j < 3; j++) {
            const slot = document.createElement('div');
            slot.classList.add('slot');
            slot.textContent = `Slot ${j + 1}`;
            slot.setAttribute('data-date', `${year}-${month + 1}-${i}`);
            slot.addEventListener('click', reserveSlot);
            dayElement.appendChild(slot);
        }

        calendarElement.appendChild(dayElement);
    }
}

// Function to handle slot reservation
function reserveSlot(event) {
    const slot = event.target;
    slot.classList.toggle('reserved');
}

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

// Initial calendar generation
const currentDate = new Date();
generateCalendar(currentDate.getFullYear(), currentDate.getMonth());

// Button event listeners
document.getElementById('prev-month').addEventListener('click', prevMonth);
document.getElementById('next-month').addEventListener('click', nextMonth);
