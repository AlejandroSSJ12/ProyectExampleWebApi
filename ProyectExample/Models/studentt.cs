using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectExample.Models
{
    public class studentt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual List<groupStudent> GroupsStudents { get; set; }
    }

    public class studenttDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}