using System;
using EFCore.Models;
namespace EFCore.Responsitory{
    public interface IStudentResponsitory{
        public List<Student> GetAll();
        public void Create(Student std);
        public void Update(Student std);
        public void Delete(int id);
    }
}