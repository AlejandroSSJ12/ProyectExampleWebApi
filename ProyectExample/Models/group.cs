using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectExample.Models
{
    public class group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<groupStudent> GroupStudents{ get; set; }
    }

    public class groupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}