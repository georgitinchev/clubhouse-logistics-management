using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Classes
{
    public class EmployeeHandler
    {
        private Dictionary<string, Employee> employees;

        public EmployeeHandler()
        {
            employees = new Dictionary<string, Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (!employees.ContainsKey(employee.GetUsername()))
            {
                employees.Add(employee.GetUsername(), employee);
            }
            else
            {
                Console.WriteLine("Username already exists. Please choose a different username.");
            }
        }

        public void RemoveEmployee(string username)
        {
            if (employees.ContainsKey(username))
            {
                employees.Remove(username);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public Employee GetEmployee(string username)
        {
            if (employees.ContainsKey(username))
            {
                return employees[username];
            }
            else
            {
                Console.WriteLine("Employee not found.");
                return null;
            }
        }

        public bool Authenticate(string username, string password)
        {
            if (employees.ContainsKey(username))
            {
                return employees[username].ValidatePassword(password);
            }
            else
            {
                Console.WriteLine("Employee not found.");
                return false;
            }
        }
    }
}
