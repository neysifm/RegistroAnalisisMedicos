﻿using AnalisisMedicos.Entidades;
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
        public DbSet<Analisis> Analisis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<TiposAnalisis> TiposAnalisis { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
