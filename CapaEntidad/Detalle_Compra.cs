using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Compra
    {
            public int idDCompra {  get; set; }
            public Compra idCompra {  get; set; }
            public Producto idproducto {  get; set; }
            public decimal Precio_compra {  get; set; }
            public decimal Precio_Venta {  get; set; }
            public int cantidad {  get; set; }
            public decimal Montototal { get; set; }
            public string Fecha_Registro {  get; set; }
    }
}
