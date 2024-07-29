using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaMercado
{
    public class CM_Usuario
    {
        private CD_Usuario objcd_Usuario = new CD_Usuario();

        public  List<Usuario> Listar ()
        {
            return objcd_Usuario.Listar();
        }
    }
}
