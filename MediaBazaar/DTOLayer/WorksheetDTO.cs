using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class WorksheetDTO
    {
        public int TimeSlot {  get; set; }
        public int WeekDay {  get; set; }
        public int Id { get; set; }
        public int EmployeeId {  get; set; }
        public int WeekNr {  get; set; }
    }
}
