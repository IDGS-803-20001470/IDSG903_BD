using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace IDGS903_BD.Models
{
    public class AlumnosDbContext: DbContext
    {
        private static string conexion= "DefaultConnection" ;
        public AlumnosDbContext() : base(conexion) { }
        
            public DbSet<Alumnos> Alumnos { get; set; }
        
    }
}