using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra {  get; set; }
            public Usuario idusuario {  get; set; }
            public Proveedor idproverdor {  get; set; }
            public string TipoDocumento {  get; set; }
            public string NumeroDocumento {  get; set; }
            public decimal Montototal {  get; set; }
            public List <Detalle_Compra> Detalle_Compra {  get; set; }
            public string Fecha_Registro {  get; set; }
    }
}
