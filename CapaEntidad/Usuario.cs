using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
           public int idusuario {  get; set; }
            public string documento {  get; set; }
            public string Razon_Social {  get; set; }
            public string correo {  get; set; }
            public string clave {  get; set; }
            public Rol idrol {  get; set; }
            public bool estado {  get; set; }
            public string Fecha_Registro {  get; set; }
        public string? NombreCompleto { get; set; }
    }
}
