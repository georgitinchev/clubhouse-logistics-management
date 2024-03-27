using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTOLayer
{
    public class ContractDTO
    {
        public int Id {  get; set; }
        public int Role {  get; set; }
        public decimal HourlyWage {  get; set; }
        public int WeeklyHours {  get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime? EndDate {  get; set; }
        public bool IsActive {  get; set; }
        public string? TerminationReason {  get; set; }
        public DateTime? Availability {  get; set; }

        public ContractDTO(int id, int role, decimal hourlyWage, int weeklyHours, DateTime startDate, DateTime? endDate, bool isActive, string? terminationReason, DateTime? availability)
        {
            Id = id;
            Role = role;
            HourlyWage = hourlyWage;
            WeeklyHours = weeklyHours;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = isActive;
            TerminationReason = terminationReason;
            Availability = availability;
        }
    }
}
