using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigFood_service.Models
{
    public class Producto
    {
        public int CodigoInterno { get; set; }

        public int CodigoBarra { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }


        public int PrecioVenta { get; set; }


        public decimal Descuento { get; set; }

        public decimal Impuesto { get; set; }


        public string UnidadMedida { get; set; }


        public int PrecioCompra { get; set; }


        public int Usuario { get; set; }

        public int Existencia { get; set; }
    }
}
