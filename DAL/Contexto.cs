using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RegistroEstudiantes.Entidades;

namespace RegistroEstudiantes.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public Contexto() : base("ConStr")
        {

        }
        //public DbSet<Estudiantes> Estudiantes { get; set; }
    }
}
