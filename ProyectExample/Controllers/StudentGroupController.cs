using ProyectExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HTTPupt;

namespace ProyectExample.Controllers
{
    public class StudentGroupController : ApiController
    {
        Model1 bd = new Model1();

        [ActionName("ConsultStudents")]
        [HttpGet]
        public IQueryable<StudentGroupDTO> ConsultStudents()
        {
            var consult = from groupStudent in bd.GroupStudentss
                          select new StudentGroupDTO
                          {
                              Id = groupStudent.Id,
                              StudentId = groupStudent.StudentId,
                              StudentName = groupStudent.Student.Name,
                              StudentAge = groupStudent.Student.Age,
                              GroupID = groupStudent.Group.Id,
                              GrouppName = groupStudent.Group.Name,
                          };
            return consult;
        }

        [ActionName("Insert")]
        [HttpPost]
        public bool Insert(List<groupStudent> GroupsStudentss)
        {
            try
            {
                foreach (groupStudent student in bd.GroupStudentss)
                {
                    var consulta = bd.GroupStudentss.Where(c => c.GroupId == student.GroupId && c.StudentId == student.StudentId);
                    if (consulta.Count() == 0)
                    {
                        bd.GroupStudentss.Add(student);
                        bd.SaveChanges();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
