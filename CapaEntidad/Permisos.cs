using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permisos
    {
       public int idpermiso {  get; set; }
       public Rol idrol {  get; set; }

        public string Descripcion { get; set; }

        public string Fecha_Registro {  get; set; }
    }

}
