using ProyectExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;

namespace ProyectExample.Controllers
{
    public class GroupController : ApiController
    {
        Model1 bd = new Model1();
        [ActionName("Insert")]
        [HttpPost]

        public string Insert(group Groups)
        {
            try
            {
                bd.Groups.Add(Groups);
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
        public IQueryable<groupDTO> ConsultStudents()
        {
            var consult = from Group in bd.Groups
                          select new groupDTO
                          {
                                Id = Group.Id,
                                Name = Group.Name
                          };
            return consult;
        }
    }

}
