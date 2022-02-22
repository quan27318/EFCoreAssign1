using EFCore.Models;
using EFCore.Responsitory;
namespace EFCore.Services
{
    public class StudentServices : IServices
    {
        private readonly  IStudentResponsitory _studentResponsitory ;

        public StudentServices(IStudentResponsitory iStudentResponsitory)
        {
            _studentResponsitory = iStudentResponsitory;
        }
        public List<Student> GetAll(){
            return _studentResponsitory.GetAll();
            
        }
        public void Create(Student std){
            
            _studentResponsitory.Create(std);
        }
        public void Update(Student std){
            _studentResponsitory.Update(std);
        }
        public void Delete(int  id){
            _studentResponsitory.Delete(id);
        }
    }
}