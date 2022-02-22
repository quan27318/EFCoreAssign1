using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCore.Models;
using EFCore.Services;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _iStudent;
        public StudentController(IStudent iStudent) 
        {
            _iStudent = iStudent;
        }
       [HttpGet]
       public List<Student> GetAll(){
           return _iStudent.GetAll();
       }
       [HttpPost]
       public HttpStatusCode Create(Student std){
           _iStudent.Create(std);
           return HttpStatusCode.OK;
       }
       [HttpPut]
       public HttpStatusCode Update(Student std){
           _iStudent.Update(std);
           return HttpStatusCode.OK;
       }
       [HttpDelete]
       public HttpStatusCode Delete(int id){
           _iStudent.Delete(id);
           return HttpStatusCode.OK;
       }
    }
}