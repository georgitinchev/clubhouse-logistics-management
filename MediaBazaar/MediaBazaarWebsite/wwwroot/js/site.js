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
document.getElementById('next-month').addEventListener('click', nextMonth);1


document.addEventListener("DOMContentLoaded", function() {
  // Get reference to the slots container
  const slotsContainer = document.querySelector(".slots");

  // Function to fetch shift data from backend and populate slots
  function populateSlots(week) {
    // Clear existing slots
    slotsContainer.innerHTML = "";

    // Assuming 'getShiftData' is a function to fetch shift data from backend
    const shiftData = getShiftData(week);

    // Iterate through shift data and create slots
    shiftData.forEach((shift) => {
      const slot = document.createElement("div");
      slot.classList.add("slot");
      slot.textContent = shift.startTime + " - " + shift.endTime;

      // You can further customize the slot based on shift properties (e.g., add class based on shift type)

      // Append slot to slots container
      slotsContainer.appendChild(slot);
    });
    }
    // Add event listener to slots for click events
    document.querySelectorAll('.slot').forEach(slot => {
        slot.addEventListener('click', function () {
            const selected = slot.getAttribute('data-selected') === 'true';
            const slotId = slot.getAttribute('data-slot-id');

            // Toggle selection
            if (!selected) {
                // If slot is not already selected, mark it as selected
                slot.classList.add('selected');
                slot.setAttribute('data-selected', 'true');

                // Get user name (you need to replace 'USER_NAME' with the actual user name)
                const userName = 'USER_NAME'; // You need to replace this with the actual user name

                // Display user name on the slot
                slot.querySelector('.user-name').textContent = userName;

                // Call function to send selected slot information to server
                sendSlotSelection(slotId);
            } else {
                // If slot is already selected, deselect it
                slot.classList.remove('selected');
                slot.setAttribute('data-selected', 'false');

                // Remove user name from the slot
                slot.querySelector('.user-name').textContent = '';

                // Call function to send deselected slot information to server
                sendSlotDeselection(slotId);
            }
        });
    });

    // Function to send selected slot information to server
    function sendSlotSelection(slotId) {
        // Send AJAX request to server to inform about slot selection
        // You need to replace 'YOUR_API_ENDPOINT' with the actual endpoint of your backend API
        fetch('YOUR_API_ENDPOINT', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ slotId: slotId })
        })
            .then(response => {
                if (response.ok) {
                    console.log('Slot selection sent to server');
                } else {
                    console.error('Failed to send slot selection to server');
                }
            })
            .catch(error => {
                console.error('Error occurred while sending slot selection:', error);
            });
    }

    // Function to send deselected slot information to server
    function sendSlotDeselection(slotId) {
        // Send AJAX request to server to inform about slot deselection
        // You need to replace 'YOUR_API_ENDPOINT' with the actual endpoint of your backend API
        fetch('YOUR_API_ENDPOINT', {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ slotId: slotId })
        })
            .then(response => {
                if (response.ok) {
                    console.log('Slot deselection sent to server');
                } else {
                    console.error('Failed to send slot deselection to server');
                }
            })
            .catch(error => {
                console.error('Error occurred while sending slot deselection:', error);
            });
    }







  function getShiftData(week) {
    return [
      { day: "Monday", startTime: "09:00", endTime: "12:00" },
      { day: "Tuesday", startTime: "13:00", endTime: "17:00" },
    ];
  }

  populateSlots("Week 1");

  document.getElementById("prev-week-btn").addEventListener("click", function() {
    const currentWeek = document.getElementById("current-week").textContent;
    const weekNumber = parseInt(currentWeek.split(" ")[1]);
    const prevWeek = "Week " + (weekNumber - 1);
    document.getElementById("current-week").textContent = prevWeek;
    populateSlots(prevWeek);
  });

  document.getElementById("next-week-btn").addEventListener("click", function() {
    const currentWeek = document.getElementById("current-week").textContent;
    const weekNumber = parseInt(currentWeek.split(" ")[1]);
    const nextWeek = "Week " + (weekNumber + 1);
    document.getElementById("current-week").textContent = nextWeek;
    populateSlots(nextWeek);
  });
});

