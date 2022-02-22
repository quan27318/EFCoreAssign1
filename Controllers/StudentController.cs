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
        private readonly IServices _iServices;
        public StudentController(IServices iServices) 
        {
            _iServices = iServices;
        }
       [HttpGet]
       public List<Student> GetAll(){
           return _iServices.GetAll();
       }
       [HttpPost]
       public HttpStatusCode Create(Student std){
           _iServices.Create(std);
           return HttpStatusCode.OK;
       }
       [HttpPut]
       public HttpStatusCode Update(Student std){
           _iServices.Update(std);
           return HttpStatusCode.OK;
       }
       [HttpDelete]
       public HttpStatusCode Delete(int id){
           _iServices.Delete(id);
           return HttpStatusCode.OK;
       }
    }
}