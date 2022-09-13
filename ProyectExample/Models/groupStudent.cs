using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectExample.Models
{
    public class groupStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual studentt Student { get; set; }
        public int GroupId { get; set; }
        public virtual group Group { get; set; }

    }

    public class StudentGroupDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public int StudentAge { get; set; }
        public int GroupID { get; set; }
        public String GrouppName { get; set; }


    }
}