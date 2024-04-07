using DTOLayer;
using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
    public partial class AddWorksheetDialogue : Form
    {
        private EmployeeWorksheetManager _employeeWorksheetManager;
        private EmployeeManager _employeeManager;

        public AddWorksheetDialogue(EmployeeManager employeeManager, EmployeeWorksheetManager worksheetManager)
        {
            InitializeComponent();
            _employeeWorksheetManager = worksheetManager;
            _employeeManager = employeeManager;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateFields();

                string employeeName = textBoxEmployeeWorksheet.Text;
                WeekDayEnum weekDay = (WeekDayEnum)comboBoxWeekDay.SelectedIndex + 1;
                int weekNr = Convert.ToInt32(textBoxWeekNumber.Text);
                WorkingTime timeSlot = (WorkingTime)comboBoxTimeSlot.SelectedIndex + 1;

                int employeeId = GetEmployeeIdByName(employeeName);
                if (employeeId == -1)
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }

                EmployeeWorksheet worksheet = new EmployeeWorksheet(timeSlot, weekDay, employeeId, weekNr);

                _employeeWorksheetManager.AddWorksheetToDB(worksheet);

                MessageBox.Show("Worksheet created and added to the database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ValidateFields()
        {
            if (comboBoxWeekDay.SelectedItem == null)
            {
                throw new Exception("Please select a week day.");
            }

            if (comboBoxTimeSlot.SelectedItem == null)
            {
                throw new Exception("Please select a time slot.");
            }

            if (string.IsNullOrEmpty(textBoxEmployeeWorksheet.Text))
            {
                throw new Exception("Please enter the employee's name.");
            }

            if (string.IsNullOrEmpty(textBoxWeekNumber.Text) || !int.TryParse(textBoxWeekNumber.Text, out int weekNr))
            {
                throw new Exception("Week number must be a valid integer.");
            }
        }

        private Employee GetEmployeeByName(string name)
        {
            return _employeeManager.GetAllEmployees().FirstOrDefault(emp => $"{emp.FirstName} {emp.LastName}" == name);
        }

        private int GetEmployeeIdByName(string name)
        {
            Employee employee = GetEmployeeByName(name);
            return employee != null ? employee.EmployeeID : -1;
        }
    }
}
