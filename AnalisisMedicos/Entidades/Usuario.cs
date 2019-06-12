using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisMedicos.Entidades
{
    public class Usuario
    {
        [Key]

        public int UsuarioId { get; set; }
        public String Nombres { get; set; }
        public String Email { get; set; }
        public String NivelUsuario { get; set; }
        public String Clave { get; set; }

        public Usuario()
        {
            UsuarioId = 0;
            Nombres = String.Empty;
            Email = String.Empty;
            NivelUsuario = String.Empty;
            Clave = String.Empty;
        }

    }
}
