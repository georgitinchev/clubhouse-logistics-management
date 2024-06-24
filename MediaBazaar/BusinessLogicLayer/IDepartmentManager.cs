
namespace BusinessLogicLayer
{
    public interface IDepartmentManager
    {
        void Add(Department department);
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        void Remove(int id);
        IEnumerable<Department> Search(string query);
        void Update(Department department);
    }
}