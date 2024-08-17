using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigFood_service.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Login { get; set; }


        public string Password { get; set; }


        public DateTime FechaRegistro { get; set; }


        public char Estado { get; set; }
    }
}
