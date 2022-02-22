using System;
using System.Collections.Generic;
using EFCore.Models;
namespace EFCore.Responsitory
{
    public class StudentResponsitory :IStudentResponsitory
    {
        private StudentDbContext _studentDbContext;
       
        public StudentResponsitory(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public List<Student> GetAll()
        {
            return _studentDbContext.Students.ToList();
        }
        public void Create(Student std){
            _studentDbContext.Students.Add(std);
            _studentDbContext.SaveChanges();
        }
        public void Update(Student std){
            var student = _studentDbContext.Students.Where(x=>x.StudentID == std.StudentID).FirstOrDefault();
            student.FirstName = std.FirstName;
            student.LastName = std.LastName;
            student.City=std.City;
            student.State=std.State;
            _studentDbContext.SaveChanges();
        }
        public void Delete(int id){
            var student = _studentDbContext.Students.Where(x=>x.StudentID== id).FirstOrDefault();
            _studentDbContext.Remove(student);
            _studentDbContext.SaveChanges();
        }

    }
}