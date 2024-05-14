using DTOLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace MediaBazaarWebsite.Pages
{
    public class AvailabilityCalendarModel : PageModel
    {
        public DateTime Today { get; set; }
        public int CurrentMonth { get; set; }
        public int CurrentYear { get; set; }
        public string CurrentMonthName { get; set; }
        public List<string> DayNames { get; set; }
        public List<List<DateTime>> Weeks { get; set; }
        public List<WorkingTime> TimeSlots { get; set; }
        public List<string> SelectedTimeSlots { get; set; }

        public void OnGet()
        {
            Today = DateTime.Today;
            CurrentMonth = Today.Month;
            CurrentYear = Today.Year;
            TimeSlots = Enum.GetValues(typeof(WorkingTime)).Cast<WorkingTime>().ToList();
            CurrentMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(CurrentMonth);
            DayNames = new List<string> { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            DateTime firstDayOfMonth = new DateTime(CurrentYear, CurrentMonth, 1);
            int daysInMonth = DateTime.DaysInMonth(CurrentYear, CurrentMonth);

            // Initialize the 'Weeks' list with empty weeks (as needed)
            Weeks = new List<List<DateTime>>();
            for (int i = 0; i < 6; i++)
            {
                Weeks.Add(new List<DateTime>());
            }

            int currentDay = 1;
            for (int i = 0; i < Weeks.Count; i++)
            {
                for (int j = 0; j < 7 && currentDay <= daysInMonth; j++)
                {
                    DateTime day = firstDayOfMonth.AddDays(currentDay - 1);
                    Weeks[i].Add(day);
                    currentDay++;
                }
            }

            // ... (The rest of the OnPost method remains the same)
        }

        // ... (The rest of the code remains the same)

        public IActionResult OnPost(List<string> selectedTimeSlots)
        {
            var invalidDays = selectedTimeSlots
        .GroupBy(s => s.Split(" - ")[0])  // Replace ' - ' with " - "
        .Where(g => g.Count() > 2)
        .Select(g => g.Key);

            if (invalidDays.Any())
            {
                ModelState.AddModelError("", "You can only select up to 2 time slots per day.");
                return Page();
            }
            SelectedTimeSlots = selectedTimeSlots;

            return RedirectToPage("/AvailabilityCalendar");
           
        }

    }
}
