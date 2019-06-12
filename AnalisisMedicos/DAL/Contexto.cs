using AnalisisMedicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisMedicos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Analisis> AnalisisM { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TiposAnalisis> TipoAnalisis { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
