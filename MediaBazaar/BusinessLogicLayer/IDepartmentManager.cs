
namespace BusinessLogicLayer
{
    public interface IDepartmentManager
    {
        void AddDepartment(Department department);
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        void RemoveDepartment(int id);
        IEnumerable<Department> SearchDepartment(string query);
        void UpdateDepartment(Department department);
    }
}