using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int idventa { get; set; }
        public Usuario idusuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public string Documento_cliente { get; set; }

        public string Nombre_cliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal Montototal { get; set; }

        public List <Detalle_Venta> Detalle_Ventas { get; set; }
        public string Fecha_Registro { get; set; }
    }
}
