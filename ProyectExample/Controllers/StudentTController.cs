using ProyectExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectExample.Controllers
{
    public class StudentTController : ApiController
    {
        Model1 bd = new Model1();
        [ActionName ("Insert")]
        [HttpPost]

        public string Insert (studentt Studentss)
        {
            try
            {
                bd.Students.Add(Studentss);
                bd.SaveChanges();
                return "Consulta realizada con exito";
            }
            catch
            {
                return "Consulta no realizada";
            }
        }
        [ActionName("ConsultStudents")]
        [HttpGet]
        public IQueryable<studenttDTO> ConsultStudents()
        {
            var consult = from studentt in bd.Students
                          select new studenttDTO
                          {
                              Id = studentt.Id,
                              Name = studentt.Name,
                              Age = studentt.Age
                          };
            return consult;
        }
    }
}
