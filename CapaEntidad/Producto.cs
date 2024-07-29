using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int idproducto { get; set; }
        public string codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Categoriacs categoria { get; set; }
        public int stock { get; set; }

        public decimal Precio_compra {  get; set; }

        public decimal Precio_Venta { get; set; }
        public bool estado { get; set; }
        public string Fecha_Registro { get; set; }
    }
}
