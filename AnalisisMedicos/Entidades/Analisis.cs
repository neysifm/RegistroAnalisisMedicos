using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisMedicos.Entidades
{
    public class Analisis
    {
        [Key]

        public int AnalisisId { get; set; }
        public int UsuarioId  { get; set; }
        public DateTime Fecha { get; set; }

        public Analisis()
        {
            AnalisisId = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;
        }
    }
}
