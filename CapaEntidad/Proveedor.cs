using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Proveedor
    {
        public int idproverdor { get; set; }
        public string descripcion { get; set; }
        public string Razon_Social { get; set; }
        public string correo { get; set; }
        public string Telefono { get; set; }
        public bool estado { get; set; }
        public string Fecha_Registro { get; set; }
    }
}
