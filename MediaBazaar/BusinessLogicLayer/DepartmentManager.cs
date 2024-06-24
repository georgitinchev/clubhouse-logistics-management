using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly List<Department> _departments = new List<Department>();

        public void Add(Department department)
        {
            _departments.Add(department);
        }

        public void Update(Department department)
        {
            var existing = _departments.FirstOrDefault(d => d.Id == department.Id);
            if (existing != null)
            {
                existing.Name = department.Name;
                existing.Description = department.Description;
                existing.RequiredPersonnel = department.RequiredPersonnel;
                existing.PointOfContact = department.PointOfContact;
            }
        }

        public void Remove(int id)
        {
            var department = _departments.FirstOrDefault(d => d.Id == id);
            if (department != null)
            {
                _departments.Remove(department);
            }
        }

        public Department GetById(int id)
        {
            return _departments.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Department> Search(string query)
        {
            return _departments.Where(d => d.Name.Contains(query) || d.Description.Contains(query));
        }

        public IEnumerable<Department> GetAll()
        {
            return _departments;
        }
    }
}
