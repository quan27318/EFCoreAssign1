using EFCore.Models;
namespace EFCore.Services
{
    public interface IStudent
    {
        public List<Student> GetAll();
        public void Create(Student std);
        public void Update(Student std);
        public void Delete(int  id);
    }
}