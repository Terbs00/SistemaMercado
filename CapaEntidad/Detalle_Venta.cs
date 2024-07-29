using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Venta
    {

        public int idDVenta { get; set; }
        public Producto Producto { get; set; }
        public decimal Precio_Venta { get; set; }

        public int Cantidad {  get; set; }
        public decimal Subtotal { get; set; }
        public string Fecha_Registro { get; set; }
    }
}
