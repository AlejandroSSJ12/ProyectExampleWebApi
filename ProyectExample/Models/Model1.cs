using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProyectExample.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=mainModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<group> Groups { get; set; }
        public  virtual DbSet<studentt> Students { get; set; }
        public virtual DbSet <groupStudent> GroupStudentss { get; set; }

    }
}
